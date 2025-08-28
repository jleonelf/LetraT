using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;

namespace LetraT
{
    public class Game : GameWindow
    {

        private Poligono psfrente;
        private Poligono pstraser;
        private Poligono psizquie;
        private Poligono psderech;
        private Poligono psarriba;
        private Poligono psabajo;

        private Poligono pifrente;
        private Poligono pitraser;
        private Poligono piizquie;
        private Poligono piderech;
        private Poligono piarriba;
        private Poligono piabajo;

        private Partes parteSup;
        private Partes parteInf;

        private Objeto letraT;

        private Escenario escenario;

        public Game(int width, int height) : base(width, height, GraphicsMode.Default, "Diseño Letra T - 3D")
        {
            // Parte superior
            this.psfrente = new Poligono(new Color4(0.5f, 0.1f, 0.0f, 1.0f));
            psfrente.addVertice(-0.50f, 0.50f, 0.15f);
            psfrente.addVertice( 0.50f, 0.50f, 0.15f);
            psfrente.addVertice( 0.50f, 0.20f, 0.15f);
            psfrente.addVertice(-0.50f, 0.20f, 0.15f);
            psfrente.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.pstraser = new Poligono(new Color4(0.5f, 0.1f, 0.0f, 1.0f));
            pstraser.addVertice(-0.50f, 0.50f, -0.15f);
            pstraser.addVertice( 0.50f, 0.50f, -0.15f);
            pstraser.addVertice( 0.50f, 0.20f, -0.15f);
            pstraser.addVertice(-0.50f, 0.20f, -0.15f);
            pstraser.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.psizquie = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            psizquie.addVertice(-0.50f, 0.50f, 0.15f);
            psizquie.addVertice(-0.50f, 0.50f, -0.15f);
            psizquie.addVertice(-0.50f, 0.20f, -0.15f);
            psizquie.addVertice(-0.50f, 0.20f, 0.15f);
            psizquie.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.psderech = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            psderech.addVertice( 0.50f, 0.50f, 0.15f);
            psderech.addVertice( 0.50f, 0.50f, -0.15f);
            psderech.addVertice( 0.50f, 0.20f, -0.15f);
            psderech.addVertice( 0.50f, 0.20f, 0.15f);
            psderech.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.psarriba = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            psarriba.addVertice(-0.50f, 0.50f, 0.15f);
            psarriba.addVertice(-0.50f, 0.50f, -0.15f);
            psarriba.addVertice( 0.50f, 0.50f, -0.15f);
           // psarriba.addVertice( 0.50f, 0.50f, 0.15f);
            psarriba.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.psabajo = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            psabajo.addVertice(-0.50f, 0.20f, 0.15f);
            psabajo.addVertice(-0.50f, 0.20f, -0.15f);
            psabajo.addVertice( 0.50f, 0.20f, -0.15f);
            psabajo.addVertice( 0.50f, 0.20f, 0.15f);
            psabajo.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            // Parte Inferior
            this.pifrente = new Poligono(new Color4(0.5f, 0.1f, 0.0f, 1.0f));
            pifrente.addVertice(-0.20f, 0.20f, 0.15f);
            pifrente.addVertice(0.20f, 0.20f, 0.15f);
            pifrente.addVertice(0.20f, -0.60f, 0.15f);
            pifrente.addVertice(-0.20f, -0.60f, 0.15f);
            pifrente.setCentro(new Punto(0.0f, 0.0f, 0.0f));
            
            this.pitraser = new Poligono(new Color4(0.5f, 0.1f, 0.0f, 1.0f));
            pitraser.addVertice(-0.20f, 0.20f, -0.15f);
            pitraser.addVertice(0.20f, 0.20f, -0.15f);
            pitraser.addVertice(0.20f, -0.60f, -0.15f);
            pitraser.addVertice(-0.20f, -0.60f, -0.15f);
            pitraser.setCentro(new Punto(0.0f, 0.0f, 0.0f));
            
            this.piizquie = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            piizquie.addVertice(-0.20f, 0.20f, 0.15f);
            piizquie.addVertice(-0.20f, 0.20f, -0.15f);
            piizquie.addVertice(-0.20f, -0.60f, -0.15f);
            piizquie.addVertice(-0.20f, -0.60f, 0.15f);
            piizquie.setCentro(new Punto(0.0f, 0.0f, 0.0f));
            
            this.piderech = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            piderech.addVertice( 0.20f, 0.20f, 0.15f);
            piderech.addVertice( 0.20f, 0.20f, -0.15f);
            piderech.addVertice( 0.20f, -0.60f, -0.15f);
            piderech.addVertice( 0.20f, -0.60f, 0.15f);
            piderech.setCentro(new Punto(0.0f, 0.0f, 0.0f));
            
            this.piarriba = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            piarriba.addVertice(-0.20f, 0.20f, 0.15f);
            piarriba.addVertice(-0.20f, 0.20f, -0.15f);
            piarriba.addVertice(0.20f, 0.20f, -0.15f);
            piarriba.addVertice(0.20f, 0.20f, 0.15f);
            piarriba.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.piabajo = new Poligono(new Color4(0.0f, 0.0f, 0.5f, 1.0f));
            piabajo.addVertice(-0.20f, -0.60f, 0.15f);
            piabajo.addVertice(-0.20f, -0.60f, -0.15f);
            piabajo.addVertice(0.20f, -0.60f, -0.15f);
            piabajo.addVertice(0.20f, -0.60f, 0.15f);
            piabajo.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.parteSup = new Partes();
            this.parteSup.add("Parte superior frente", psfrente);
            this.parteSup.add("Parte superior atras", pstraser);
            this.parteSup.add("Parte superior izquierda", psizquie);
            this.parteSup.add("Parte superior derecha", psderech);
            this.parteSup.add("Parte superior arriba", psarriba);
            this.parteSup.add("Parte superior abajo", psabajo);
            this.parteSup.setCentro(new Punto(0.0f, 0.0f, 0.0f));

            this.parteInf = new Partes();
            this.parteInf.add("Parte inferior frente", pifrente);
            this.parteInf.add("Parte inferior atras", pitraser);
            this.parteInf.add("Parte inferior izquierda", piizquie);
            this.parteInf.add("Parte inferior derecha", piderech);
            this.parteInf.add("Parte inferior arriba", piarriba);
            this.parteInf.add("Parte inferior abajo", piabajo);

            this.letraT = new Objeto();
            this.letraT.addParte("LetraT parte superior", parteSup);
            this.letraT.addParte("LetraT parte inferior", parteInf);
            this.letraT.setCentro(new Punto(0.0f, 0.0f, 0.0f));


            this.escenario = new Escenario(new Vector3(0, 0, 0));
            this.escenario.addObjeto("Letra T", letraT);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(0.0f, 0.5f, 0.0f, 1.0f);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            float aspectRatio = (float)Width / Height;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45.0f), aspectRatio, 0.1f, 100.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }



        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            // Configura la cámara
            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0.0f, 2f, 3.5f), // Posición de la cámara
                new Vector3(0.0f, 0.1f, 0.0f), // Punto de mira
                Vector3.UnitY); // Vector arriba
            GL.LoadMatrix(ref modelview);
            
            escenario.dibujar(new Vector3(0, 0, 0));

            GL.End();
            SwapBuffers();
        }
    }
}
