using System;

using BuildErrorMT3001.Models;

namespace BuildErrorMT3001.ViewModels {
    public class ItemDetailViewModel : BaseViewModel {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null) {
            Title = item?.Text;
            Item = item;
        }
    }
}
