using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Modules;

namespace PresentationLayer
{
    public partial class MainMenu : Form
    {
        private Dictionary<String,UserControl> modules = new Dictionary<string,UserControl>();

        public MainMenu()
        {
            InitializeComponent();

            var AgregarPersona = new AgregarPersonaModule();
            var Alumnos = new AlumnosModule();
            var Carreras = new CarrerasModule();
            var Especialidades = new EspecialidadesModule();
            var Grupos = new GruposModule();
            var Horarios = new HorariosModules();
            var Materias = new MateriasModule();

            modules[agregarpersonas.Name] = AgregarPersona;
            modules[alumnos.Name] = Alumnos;
            modules[carrera.Name] = Carreras;
            modules[especialidades.Name] = Especialidades;
            modules[grupos.Name] = Grupos;
            modules[horario.Name] = Horarios;
            modules[materias.Name] = Materias;

            ShowModule(agregarpersonas.Name);

            agregarpersonas.Click += ButtonClick;
            materias.Click += ButtonClick;
            alumnos.Click += ButtonClick;
            grupos.Click += ButtonClick;
            especialidades.Click += ButtonClick;
            carrera.Click += ButtonClick;
            horario.Click += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var clickedbutton = sender as Button;
            var name = clickedbutton.Name;

            ShowModule(name);
        }

        public void ShowModule(String name)
        {
            var module = modules[name];

            if (!panelModules.Controls.Contains(module))
            {
                module.Dock = DockStyle.Fill;
                panelModules.Controls.Add(module);
            }

            module.BringToFront();
        }
    }
}
