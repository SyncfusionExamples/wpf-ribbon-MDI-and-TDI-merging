using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ribbon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ChildView1.MergeButton.Click += MergeButton_Click;
            this.ChildView1.UnMergeButton.Click += UnMergeButton_Click;
        }

        private void UnMergeButton_Click(object sender, RoutedEventArgs e)
        {
            this.parentRibbon.UnMerge(this.ChildView1.childRibbon);
        }

        private void MergeButton_Click(object sender, RoutedEventArgs e)
        {
            this.parentRibbon.Merge(this.ChildView1.childRibbon);
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            if(doc.Mode == DocumentContainerMode.TDI)
            {
                doc.Mode = DocumentContainerMode.MDI;
            }
            else
            {
                doc.Mode = DocumentContainerMode.TDI;
            }
        }
    }
}
