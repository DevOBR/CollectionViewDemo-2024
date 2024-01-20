using System;
using CollectionViewDemo_2024.MVVM.Models;

namespace CollectionViewDemo_2024.Selectors
{
	public class ProductDataTemplateSelector : DataTemplateSelector
	{
		public ProductDataTemplateSelector()
		{
		}

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Product;

            if (!product.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductStyle", out var productStyle);
                return productStyle as DataTemplate;
            }

            Application.Current.Resources.TryGetValue("OfferStyle", out var offerStyle);
            return offerStyle as DataTemplate;
        }
    }
}

