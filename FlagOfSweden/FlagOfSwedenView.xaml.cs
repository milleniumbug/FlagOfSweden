using System.Windows;

namespace WpfApplication1
{
    using System.Windows.Controls;

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
