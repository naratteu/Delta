﻿using System.Windows;

namespace Delta.WPF
{
    public static partial class Markup
    {
        public static IElement Row(this IElement node, int value)
        {
            return node.SetProperty ("Grid.Row", value);
        }
        public static IElement Column(this IElement node, int value)
        {
            return node.SetProperty ("Grid.Column", value);
        }
        public static IElement RowSpan(this IElement node, int value)
        {
            return node.SetProperty ("Grid.RowSpan", value);
        }
        public static IElement ColumnSpan(this IElement node, int value)
        {
            return node.SetProperty ("Grid.ColumnSpan", value);
        }
        public static IElement Size(this IElement node, double width = 0.0, double height = 0.0)
        {
            return node.Width (width)
                       .Height(height);
        }

        public static IElement Width(this IElement node, double value)
        {
            return node.SetProperty ("Width", value);
        }

        public static IElement Height(this IElement node, double value)
        {
            return node.SetProperty ("Height", value);
        }

        public static IElement Start(this IElement node)
        {
            return node.SetProperty ("HorizontalAlignment", HorizontalAlignment.Left);
        }
        public static IElement HCenter(this IElement node)
        {
            return node.SetProperty ("HorizontalAlignment", HorizontalAlignment.Center);
        }
        public static IElement End(this IElement node)
        {
            return node.SetProperty ("HorizontalAlignment", HorizontalAlignment.Right);
        }
        public static IElement Top(this IElement node)
        {
            return node.SetProperty ("VerticalAlignment", VerticalAlignment.Top);
        }
        public static IElement VCenter(this IElement node)
        {
            return node.SetProperty ("VerticalAlignment", VerticalAlignment.Center);
        }
        public static IElement Bottom(this IElement node)
        {
            return node.SetProperty ("VerticalAlignment", VerticalAlignment.Bottom);
        }
        public static IElement Center(this IElement node)
        {
            return node.HCenter ().VCenter ();
        }
    }
}
