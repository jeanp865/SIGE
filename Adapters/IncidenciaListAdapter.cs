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
using SIGE.Core.Model;

namespace SIGE.Adapters
{
    public class IncidenciaListAdapter : BaseAdapter<Incidencia>
    {

        List<Incidencia> items;
        Activity context;

        public IncidenciaListAdapter(Activity context , List<Incidencia> items)
        {
            this.items = items;
            this.context = context; 
        }

        public override Incidencia this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            if (convertView == null)
            {
                convertView =
                    //context.LayoutInflater.Inflate(Android.Resource.Layout.TestListItem, null);
                    context.LayoutInflater.Inflate(Resource.Layout.RowView, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.codigoTextView).Text = item.Cod_Incidencia;
            convertView.FindViewById<TextView>(Resource.Id.estadoTextView).Text = item.Estado;
            convertView.FindViewById<TextView>(Resource.Id.fechaRegistroTextView).Text = item.Fecha.ToShortDateString();
            convertView.FindViewById<TextView>(Resource.Id.lugarTextView).Text = item.Lugar;

            //convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Cod_Incidencia;
            return convertView; 
        }
    }
}