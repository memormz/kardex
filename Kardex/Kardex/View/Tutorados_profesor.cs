﻿using Kardex.Controller;
using Kardex.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kardex.View
{
    public partial class Tutorados_profesor : Form
    {
        public Tutorados_profesor()
        {
            InitializeComponent();
            
        }


        private List<Alumno> list = new List<Alumno>(getData.GetTutorados());

        private void LoadData()
        {         
            foreach (Alumno alumno in list)
            {
                ListViewItem item = new ListViewItem(alumno.nombre);                
                item.SubItems.Add(alumno.correo);                
                list_tutorados.Items.Add(item);
            }                   
        }

        private void Tutorados_profesor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void list_tutorados_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIControls.Detail_Tutorado(list, list_tutorados);
            new Console_maestro().WindowState = FormWindowState.Minimized;
        }
    }
}
