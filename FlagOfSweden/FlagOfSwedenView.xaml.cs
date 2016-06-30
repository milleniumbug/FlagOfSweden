using System.Windows;
using System.Windows.Controls;

namespace FlagOfSweden
{
    public partial class FlagOfSwedenView : UserControl
    {
        public static readonly DependencyProperty NestedProperty = DependencyProperty.Register(
            "Nested",
            typeof(FlagOfSwedenView), 
            typeof(FlagOfSwedenView), 
            new PropertyMetadata(default(object)));

        public FlagOfSwedenView()
        {
            InitializeComponent();
        }

        public FlagOfSwedenView Nested
        {
            get { return (FlagOfSwedenView)GetValue(NestedProperty); }
            set { SetValue(NestedProperty, value); }
        }
    }
}
