using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
	public class App : Application
	{
		static TodoItemDatabase database;
        static RegItemDatabase database1;
        static BuyItemDatabase database2;
        static CusItemDatabase database3;
        static CalItemDatabase database4;
        static StkItemDatabase database5;
        static VerifyItemDatabase database6;
        static ManItemDatabase database7;
        static PhotosItemDatabase database8;

        public App()
		{
			Resources = new ResourceDictionary();
			Resources.Add("primaryGreen", Color.FromHex("808080"));
			Resources.Add("primaryDarkGreen", Color.FromHex("808080"));

            var nav = new NavigationPage(new LoginMenu());
            //var nav = new NavigationPage(new InstoreListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
			nav.BarTextColor = Color.White;

			MainPage = nav;
		}

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
                    database = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
				}
				return database;
			}
		}

        public static RegItemDatabase Database1
        {
            get
            {
                if (database1 == null)
                {
                    database1 = new RegItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database1;
            
            }
        }

        public static BuyItemDatabase Database2
        {
            get
            {
                if (database2 == null)
                {
                    database2 = new  BuyItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database2;

            }
        }

        public static CusItemDatabase Database3
        {
            get
            {
                if (database3 == null)
                {
                    database3 = new CusItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database3;

            }
        }

        public static CalItemDatabase Database4
        {
            get
            {
                if (database4== null)
                {
                    database4 = new CalItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database4;

            }
        }

        public static StkItemDatabase Database5
        {
            get
            {
                if (database5 == null)
                {
                    database5 = new StkItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database5;

            }
        }


        public static VerifyItemDatabase Database6
        {
            get
            {
                if (database6 == null)
                {
                    database6 = new VerifyItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database6;

            }
        }

        public static ManItemDatabase Database7
        {
            get
            {
                if (database7== null)
                {
                    database7 = new ManItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database7;

            }
        }

        public static PhotosItemDatabase Database8
        {
            get
            {
                if (database8 == null)
                {
                    database8 = new PhotosItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database8;

            }
        }

        public int ResumeAtTodoId { get; set; }

		protected override void OnStart()
		{
			//Debug.WriteLine("OnStart");

			//// always re-set when the app starts
			//// users expect this (usually)
			////			Properties ["ResumeAtTodoId"] = "";
			//if (Properties.ContainsKey("ResumeAtTodoId"))
			//{
			//	var rati = Properties["ResumeAtTodoId"].ToString();
			//	Debug.WriteLine("   rati=" + rati);
			//	if (!String.IsNullOrEmpty(rati))
			//	{
			//		Debug.WriteLine("   rati=" + rati);
			//		ResumeAtTodoId = int.Parse(rati);

			//		if (ResumeAtTodoId >= 0)
			//		{
			//			var todoPage = new TodoItemPage();
			//			todoPage.BindingContext = await Database.GetItemAsync(ResumeAtTodoId);
			//			await MainPage.Navigation.PushAsync(todoPage, false); // no animation
			//		}
			//	}
			//}
		}

		protected override void OnSleep()
		{
			//Debug.WriteLine("OnSleep saving ResumeAtTodoId = " + ResumeAtTodoId);
			//// the app should keep updating this value, to
			//// keep the "state" in case of a sleep/resume
			//Properties["ResumeAtTodoId"] = ResumeAtTodoId;
		}

		protected override void OnResume()
		{
			//Debug.WriteLine("OnResume");
			//if (Properties.ContainsKey("ResumeAtTodoId"))
			//{
			//	var rati = Properties["ResumeAtTodoId"].ToString();
			//	Debug.WriteLine("   rati=" + rati);
			//	if (!String.IsNullOrEmpty(rati))
			//	{
			//		Debug.WriteLine("   rati=" + rati);
			//		ResumeAtTodoId = int.Parse(rati);

			//		if (ResumeAtTodoId >= 0)
			//		{
			//			var todoPage = new TodoItemPage();
			//			todoPage.BindingContext = await Database.GetItemAsync(ResumeAtTodoId);
			//			await MainPage.Navigation.PushAsync(todoPage, false); // no animation
			//		}
			//	}
			//}
		}
	}
}

