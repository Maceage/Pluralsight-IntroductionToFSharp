open System
open System.Windows
open System.Windows.Controls

let loadWindow() =
    let resourceLocator = new Uri("/HelloWorldWPF;component/MainWindow.xaml", UriKind.Relative)
    let window = Application.LoadComponent(resourceLocator) :?> Window
    (window.FindName("clickButton") :?> Button).Click.Add(
        fun _ -> MessageBox.Show("Hello World!") |> ignore)
    window

[<STAThread>]
(new Application()).Run(loadWindow()) |> ignore