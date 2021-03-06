using System;
using System.ComponentModel;
using System.Globalization;
using System.Maui.Xaml;

namespace System.Maui
{
	[ProvideCompiled("System.Maui.Core.XamlC.TypeTypeConverter")]
	[TypeConversion(typeof(Type))]
	public sealed class TypeTypeConverter : TypeConverter, IExtendedTypeConverter
	{
		object IExtendedTypeConverter.ConvertFromInvariantString(string value, IServiceProvider serviceProvider)
		{
			if (serviceProvider == null)
				throw new ArgumentNullException(nameof(serviceProvider));
			if (!(serviceProvider.GetService(typeof(IXamlTypeResolver)) is IXamlTypeResolver typeResolver))
				throw new ArgumentException("No IXamlTypeResolver in IServiceProvider");

			return typeResolver.Resolve(value, serviceProvider);
		}

		public override object ConvertFromInvariantString(string value) => throw new NotImplementedException();

		[Obsolete("IExtendedTypeConverter.ConvertFrom is obsolete as of version 2.2.0. Please use ConvertFromInvariantString (string, IServiceProvider) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		object IExtendedTypeConverter.ConvertFrom(CultureInfo culture, object value, IServiceProvider serviceProvider) => ((IExtendedTypeConverter)this).ConvertFromInvariantString((string)value, serviceProvider);
	}
}