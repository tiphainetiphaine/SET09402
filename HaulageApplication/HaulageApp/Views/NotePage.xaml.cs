using HaulageApp.ViewModels;

namespace HaulageApp.Views;

public partial class NotePage : ContentPage
{
    public NotePage(NoteViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    } 
}
