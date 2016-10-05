using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SIGE
{
    [Activity(Label = "SIGE", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);


            var menuListView = FindViewById<ListView>(Resource.Id.menuListView);
            //
            // Built-in layout file SimpleListItem1 contains a TextView and nothing else
            //
            menuListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, new[] { "Registrar", "Listar", "Ver" });

            menuListView.ItemClick += MenuListView_ItemClick; ;

        }

        private void MenuListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = null;

            switch (e.Position)
            {
                case 0: intent = new Intent(this, typeof(RegistrarIncidenciaActivity)); break;
                case 1: intent = new Intent(this, typeof(ListarIncidenciaActivity)); break;
                case 2: intent = new Intent(this, typeof(VerIncidenciaActivity)); break;
            }

            StartActivity(intent);
        }
    }
}

