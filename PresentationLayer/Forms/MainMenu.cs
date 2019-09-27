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

            var AgregarAlumno = new AgregaAlumnoModule();
            var AgregarProfesor = new AgregarEmpleadoModule();
            var Actividades = new ActividadesModule();
            var Calificaciones = new CalificacionesModule();
            var Grupos = new GruposModule();
            var Horarios = new HorariosModules();
            var Inasistencias = new InasistenciasModule();
            var Carreras = new CarrerasModule();

            modules[bAgregarAlumnos.Name] = AgregarAlumno;
            modules[bAgregarEmpleados.Name] = AgregarProfesor;
            modules[bCalificaciones.Name] = Calificaciones;
            modules[bGrupos.Name] = Grupos;
            modules[bHorarios.Name] = Horarios;
            modules[bInasistencias.Name] = Inasistencias;
            modules[bActividades.Name] = Actividades;
            modules[bCarreras.Name] = Carreras;

            ShowModule(bAgregarAlumnos.Name);

            bAgregarAlumnos.Click += ButtonClick;
            bAgregarEmpleados.Click += ButtonClick;
            bInasistencias.Click += ButtonClick;
            bGrupos.Click += ButtonClick;
            bCalificaciones.Click += ButtonClick;
            bActividades.Click += ButtonClick;
            bHorarios.Click += ButtonClick;
            bActividades.Click += ButtonClick;
            bCarreras.Click += ButtonClick;

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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
