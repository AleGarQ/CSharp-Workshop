using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWorkshop
{
    public partial class Form1 : Form
    {
        public List<Municipality> Municipalities { get; set; }

        public Form1()
        {
            Municipalities = GetMunicipalities();
            InitializeComponent();
        }

        private List<Municipality> GetMunicipalities()
        {
            var list = new List<Municipality>();

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadData = new OpenFileDialog();

            if (loadData.ShowDialog() == DialogResult.OK)
            {

                string rutan = loadData.FileName;

                lblRoute.Text = rutan;

                /*datos = new Datos(rutan);

                ArrayList departamentos = datos.getLista();

                for (int i = 0; i < departamentos.Count; i++)
                {

                    int n = dtgv.Rows.Add();

                    dtgv.Rows[n].Cells[0].Value = ((Departamento)departamentos[i]).getRegion();
                    dtgv.Rows[n].Cells[1].Value = ((Departamento)departamentos[i]).getCodDep();
                    dtgv.Rows[n].Cells[2].Value = ((Departamento)departamentos[i]).getNombre();
                    dtgv.Rows[n].Cells[3].Value = ((Departamento)departamentos[i]).getCodMun();
                    dtgv.Rows[n].Cells[4].Value = ((Departamento)departamentos[i]).getMunicipio();

                }

                grafica.Titles.Add("Municipios por departamento");

                for (int i = 0; i < series.Length; i++)
                {

                    //titulos
                    Series serie = grafica.Series.Add(series[i]);

                    //cantidades
                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
