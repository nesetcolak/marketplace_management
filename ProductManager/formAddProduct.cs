using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketplaceManagement
{
    public partial class formAddProduct : Form
    {
        private Stock stock;
        
        public formAddProduct()
        {
            InitializeComponent();
            stock = new Stock();


        }


        private void formProductManagement_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Tişört"); 
            comboBoxCategory.Items.Add("Pantolon");
            comboBoxCategory.Items.Add("Hırka");


        }

        private bool ValidateForm()
        {
           
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAmount.Text) || string.IsNullOrEmpty(comboBoxCategory.Text) || string.IsNullOrEmpty(comboBoxStore.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;  
            }

            
            if (!int.TryParse(textBoxAmount.Text, out int adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir adet girin (pozitif bir sayı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (textBoxName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ürün ismi kısmına sayı giremezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private int currentID = 1;
        private string idCreator()
        {
            
            string id = comboBoxCategory.Text[0]+ "-" + currentID.ToString("D4");
            currentID++;
           
            return id;
        }

        public class Stock
        {
            private Dictionary<string, Store> storeDictionary;  // Store isimlerini ve şubeleri tutacak

            // Constructor
            public Stock()
            {
                storeDictionary = new Dictionary<string, Store>();
            }

            public bool ContainsStore(string storeName)
            {
                return storeDictionary.ContainsKey(storeName);
            }

            // Şube ekleme
            public void AddStore(Store store)
            {
                if (!storeDictionary.ContainsKey(store.Name))
                {
                    storeDictionary[store.Name] = store;  // Şube adı yoksa yeni şube ekle
                }
            }

            // Şubedeki stok güncelleme
            public void UpdateStock(string storeName, string productName, int quantity)
            {
                if (storeDictionary.ContainsKey(storeName))
                {
                    storeDictionary[storeName].UpdateStock(productName, quantity);  // Şubeye stok ekle
                }
            }

            // Şubedeki belirli ürünün stok bilgisini alma
            public int GetStock(string storeName, string productName)
            {
                if (storeDictionary.ContainsKey(storeName))
                {
                    return storeDictionary[storeName].GetStock(productName);  // Stok bilgisi döndür
                }
                return 0;
            }
        }
        public class Store
        {
            public string Name { get; set; }  // Şube adı
            private Dictionary<string, int> stockDictionary;  // Ürünlere göre stok miktarlarını tutan dictionary

            // Constructor, store ismi verilir
            public Store(string name)
            {
                Name = name;
                stockDictionary = new Dictionary<string, int>();  // Her şube için boş bir stok listesi
            }

            // Şubeye ürün ekleme ve stok miktarını güncelleme
            public void UpdateStock(string productName, int quantity)
            {
                if (stockDictionary.ContainsKey(productName))
                {
                    stockDictionary[productName] += quantity;  // Eğer ürün varsa miktarı arttır
                }
                else
                {
                    stockDictionary[productName] = quantity;  // Yoksa yeni ürün ekle
                }
            }

            // Şubedeki ürünün stok miktarını döndüren fonksiyon
            public int GetStock(string productName)
            {
                if (stockDictionary.ContainsKey(productName))
                {
                    return stockDictionary[productName];  // Ürün varsa miktarı döndür
                }

                return 0;  // Ürün yoksa 0 döndür
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) // Hata kontrol
            {
                return;
            }

            // Kullanıcı tarafından girilen şube isminin Stock'a eklenmesi
            string storeName = comboBoxStore.Text;

            // Eğer şube Stock'ta yoksa ekleniyor
            if (!stock.ContainsStore(storeName))
            {
                Store newStore = new Store(storeName);
                stock.AddStore(newStore);
            }

            // Şubeye ürün ekleme
            stock.UpdateStock(storeName, comboBoxCategory.Text, int.Parse(textBoxAmount.Text));

            // Her ürün için ID oluşturulup DataGrid'e ekleniyor
            for (int i = 0; i < int.Parse(textBoxAmount.Text); i++)
            {
                dataGridView1.Rows.Add(idCreator(), textBoxName.Text, comboBoxCategory.Text, stock.GetStock(storeName, comboBoxCategory.Text), storeName);
            }

            // Yeni kategori combo box'a ekleniyor
            string newCategory = comboBoxCategory.Text;
            if (!comboBoxCategory.Items.Contains(newCategory))
            {
                comboBoxCategory.Items.Add(newCategory);
            }
        }

    }
}
