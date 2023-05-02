using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace wform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void PostBtn_Click(object sender, EventArgs e)
        {
            await SendApiRequestAsync();
        }

        private async Task SendApiRequestAsync()
        {
            string name = TxtName.Text;
            string code = TxtCode.Text;
            string Brand = TxtBrand.Text;
            string unitPrice = TxtUPrice.Text;

            string json = $"{{\"name\": \"{name}\", \"code\": \"{code}\", \"Brand\": \"{Brand}\", \"unitPrice\": \"{unitPrice}\"}}";

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7054/api/Item/add");
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    txtResult.Text = responseBody;
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode} - {errorMessage}");
                }
            }
        }

        private async void AllBTN_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7054/api/Item/listitems");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    JToken parsedJson = JToken.Parse(responseContent);
                    string beautifiedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                    txtResult.Text = beautifiedJson;
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show($"Failed to get data. Status code: {response.StatusCode}");
                }
            }
        }

        private async void ShowBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtShow.Text);

            // Construct the URL for retrieving the item by ID
            string url = $"https://localhost:7054/api/Item/{id}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
                        JToken parsedJson = JToken.Parse(responseContent);

                        string beautifiedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);

                        txtResult.Text = beautifiedJson;
                    }
                    catch (JsonReaderException ex)
                    {
                        // Handle JSON parsing exception
                        MessageBox.Show($"Failed to parse JSON: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle other exceptions
                        MessageBox.Show($"Failed to format JSON: {ex.Message}");
                    }
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show($"Failed to get item. Status code: {response.StatusCode}");
                }
            }
        }

        private async void DeleteBTN_Click(object sender, EventArgs e)
        {
            var response = await Delete(Int32.Parse(txtID.Text));
            txtResult.Text = response;
        }

        private async Task<string> Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:7054/api/Item/delete/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void UpdateBTN_Click(object sender, EventArgs e)
        {
            await UpdateAPI(Int32.Parse(txtID.Text));
        }

        private async Task UpdateAPI(int id)
        {
            string name = TxtName.Text;
            string code = TxtCode.Text;
            string Brand = TxtBrand.Text;
            string unitPrice = TxtUPrice.Text;

            string json = $"{{\"name\": \"{name}\", \"code\": \"{code}\", \"Brand\": \"{Brand}\", \"unitPrice\": \"{unitPrice}\"}}";

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, "https://localhost:7054/api/Item/update/" + id);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    txtResult.Text = responseBody;
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode} - {errorMessage}");
                }
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtResult.Text = "";
            txtShow.Text = "";
            TxtBrand.Text = "";
            TxtCode.Text = "";
            TxtName.Text = "";
            TxtUPrice.Text = "";
        }
    }
}
