using System.Collections.Generic;
using System.Linq;
using HelloShell.Models;
using Xamarin.Forms;

namespace HelloShell.Controls
{
    public class AnimalSearchHandler : SearchHandler
    {
        public IList<Animal> Animals { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Animals
                    .Where(animal => animal.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }
    }
}
