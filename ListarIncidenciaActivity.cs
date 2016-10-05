using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SIGE.Core.Service;
using SIGE.Core.Model;
using SIGE.Adapters;

namespace SIGE
{
    [Activity(Label = "Listar Incidencias", Icon = "@drawable/icon")]
    public class ListarIncidenciaActivity : Activity
    {
        private ListView incidenciaListView;
        private List<Incidencia> listIncidencias;
        private IncidenciaDataService service;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.ListarIncidencia);

            service = new IncidenciaDataService();
            listIncidencias = service.GetAllIncidencias();

            incidenciaListView = FindViewById<ListView>(Resource.Id.incidenciaListView);
            incidenciaListView.Adapter = new IncidenciaListAdapter(this, listIncidencias);

            incidenciaListView.FastScrollEnabled = true;    
        }
    }
}