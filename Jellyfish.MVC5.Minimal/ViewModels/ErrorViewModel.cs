namespace Jellyfish.MVC5.Minimal.ViewModels
{
    public class ErrorViewModel
    {
        public ErrorViewModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }
    }
}