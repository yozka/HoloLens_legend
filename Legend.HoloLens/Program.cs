using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Urho;
using Urho.Actions;
using Urho.SharpReality;
using Urho.Shapes;
using Urho.Resources;

namespace HololensLegend
{
    internal class Program
    {
        [MTAThread]
        static void Main()
        {
            var appViewSource = new UrhoAppViewSource<AApplication>(new ApplicationOptions("Data"));
            appViewSource.UrhoAppViewCreated += OnViewCreated;
            CoreApplication.Run(appViewSource);
        }

        static void OnViewCreated(UrhoAppView view)
        {
            view.WindowIsSet += View_WindowIsSet;
        }

        static void View_WindowIsSet(Windows.UI.Core.CoreWindow coreWindow)
        {
            // you can subscribe to CoreWindow events here
        }
    }
    ///----------------------------------------------------------------------------------






     ///=================================================================================
    ///
    /// 
    /// <summary>
    /// 
    /// </summary>
    /// 
    /// 
    ///----------------------------------------------------------------------------------
    public class AApplication : StereoApplication
    {
        ///----------------------------------------------------------------------------------
   




         ///=================================================================================
        ///
        /// 
        /// <summary>
        /// Constructor
        /// </summary>
        /// 
        /// 
        ///----------------------------------------------------------------------------------
        public AApplication(ApplicationOptions opts) 
            : 
                base(opts)
        {

        }
        ///----------------------------------------------------------------------------------





         ///=================================================================================
        ///
        /// 
        /// <summary>
        /// Start programm
        /// </summary>
        /// 
        /// 
        ///----------------------------------------------------------------------------------
        protected override void Start()
        {
            base.Start();

            // Enable input
            EnableGestureTapped = true;

            // Scene has a lot of pre-configured components, such as Cameras (eyes), Lights, etc.
            DirectionalLight.Brightness = 1f;
            DirectionalLight.Node.SetDirection(new Vector3(-1, 0, 0.5f));




        }
        ///----------------------------------------------------------------------------------





         ///=================================================================================
        ///
        /// 
        /// <summary>
        /// Нажатие клик
        /// </summary>
        /// 
        /// 
        ///----------------------------------------------------------------------------------
        public override void OnGestureTapped()
        {

        }
        ///----------------------------------------------------------------------------------




    }
}