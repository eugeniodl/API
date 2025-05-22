using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class UserForm : Form
    {
        private readonly HttpClient _httpClient;
        public UserForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7067/api/Users") };
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            await LoadUserAsync();
        }

        private async Task LoadUserAsync()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("Users");
            dgvUsuarios.DataSource = users;
        }
    }
}
