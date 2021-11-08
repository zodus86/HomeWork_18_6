using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace HomeWork_18_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MSSQLClientEntities context;
        public MainWindow()
        {

            InitializeComponent();
            //EFCodeFirst();

            context = new MSSQLClientEntities();
            EFBaseFirst();

        }


        /// <summary>
        /// Создание базы по типу код первый
        /// </summary>
        private void EFCodeFirst()
        {
            // <add name="DBConnection" connectionString="Data Source=ZCORP;Initial Catalog=MSSQLClient;Integrated Security=True;" providerName="System.Data.SqlClient" />

            ClientContext db = new ClientContext();

            for(int i=0; i<10; i++)
            {
                db.Clients.Add(new Client($"Иванов", $"Иван", $"Иванович", i));
                db.CcontactDate.Add(new ContactData( 880088880 + i, $"email{i}@mail.ru"));
            }
        }

        /// <summary>
        /// Создать модель по базе
        /// </summary>
        private void EFBaseFirst()
        { 
            // <add name = "MSSQLClientEntities" connectionString = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ZCORP;initial catalog=MSSQLClient;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName = "System.Data.EntityClient" />
            
            for (int i = 0; i < 10; i++)
            {
                context.Clients.Add(new Clients($"Иванов", $"Иван", $"Иванович", i));
                context.ContactDatas.Add(new ContactDatas(880088880 + i, $"email{i}@mail.ru"));
            }


            lvClient.ItemsSource = context.Clients.Local.ToBindingList<Clients>();

            var result = context.Clients.Join(context.ContactDatas,
                cl => cl.ContactDataID,
                dat => dat.ID,
                (cl, dat) => new
                {
                    cl.ClientID,
                    cl.FirstName,
                    cl.LastName,
                    cl.MiddleName,
                    dat.TelephonNumber,
                    dat.Email
                });

        }
    }
}
