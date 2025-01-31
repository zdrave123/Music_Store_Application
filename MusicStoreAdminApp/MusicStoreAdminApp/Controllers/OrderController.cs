using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using MusicStoreAdminApp.Models;
using Newtonsoft.Json;
using System.Text;

public class OrderController : Controller
{
    public OrderController()
    {
        ComponentInfo.SetLicense("FREE-LIMITED-KEY");
    }

    public IActionResult Index()
    {
        HttpClient client = new HttpClient();
        string url = "https://localhost:44383/Api/Admin/GetOrderList";

        HttpResponseMessage response = client.GetAsync(url).Result;
        var data = response.Content.ReadAsAsync<List<Order>>().Result;

        return View(data);
    }

    public IActionResult Details(Guid id)
    {
        HttpClient client = new HttpClient();
        string URL = "https://localhost:44383/Api/Admin/OrderDetails";

        var model = new { Id = id };
        HttpContent content = new StringContent(
            JsonConvert.SerializeObject(model),
            Encoding.UTF8,
            "application/json");

        HttpResponseMessage response = client.PostAsync(URL, content).Result;
        var result = response.Content.ReadAsAsync<Order>().Result;

        return View(result);
    }

    public FileContentResult CreateInvoice(Guid id)
    {
        try
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:44383/Api/Admin/OrderDetails";

            var model = new { id = id };
            HttpContent content = new StringContent(
                JsonConvert.SerializeObject(model),
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = client.PostAsync(URL, content).Result;
            var order = response.Content.ReadAsAsync<Order>().Result;

            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "ORDER INVOICE.docx");
            var document = DocumentModel.Load(templatePath);

            document.Content.Replace("{{OrderId}}", order.Id.ToString());
            document.Content.Replace("{{OwnerId}}", order.OwnerId);
            document.Content.Replace("{{CreatedAt}}", order.CreatedAt.ToString("dd/MM/yyyy HH:mm"));

            StringBuilder sb = new StringBuilder();
            if (order.BoughtItems != null && order.BoughtItems.Any())
            {
                foreach (var item in order.BoughtItems)
                {
                    sb.AppendLine($"Item: {item.ProductName} - Price: ${item.Price}");
                }
            }
            document.Content.Replace("{{Items}}", sb.ToString());

            var stream = new MemoryStream();
            document.Save(stream, new PdfSaveOptions());

            return File(
                stream.ToArray(),
                new PdfSaveOptions().ContentType,
                $"Order_{order.Id}_{DateTime.Now:yyyyMMdd}.pdf"
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating invoice: {ex.Message}");
            throw;
        }
    }
}
