using System;
using System.Maui;
using System.Maui.Platform;

namespace System.Maui.Core
{
	public class Platform
	{
		static bool HasInit;

		public static void Init()
		{
			if (HasInit)
				return;

			HasInit = true;

			Registrar.Handlers.Register<ActivityIndicator, ActivityIndicatorRenderer>();
			Registrar.Handlers.Register<Button, ButtonRenderer>();
			Registrar.Handlers.Register<CheckBox, CheckBoxRenderer>();
			Registrar.Handlers.Register<DatePicker, DatePickerRenderer>();
			Registrar.Handlers.Register<Editor, EditorRenderer>();
			Registrar.Handlers.Register<Entry, EntryRenderer>();
			Registrar.Handlers.Register<Label, LabelRenderer>();
			Registrar.Handlers.Register<StackLayout, LayoutRenderer>();
			Registrar.Handlers.Register<Picker, PickerRenderer>();
			Registrar.Handlers.Register<ProgressBar, ProgressBarRenderer>();
			Registrar.Handlers.Register<SearchBar, SearchRenderer>();
			Registrar.Handlers.Register<Slider, SliderRenderer>();
			Registrar.Handlers.Register<Stepper, StepperRenderer>();
			Registrar.Handlers.Register<Switch, SwitchRenderer>();
			Registrar.Handlers.Register<TimePicker, TimePickerRenderer>();
			Registrar.Handlers.Register<ContentPage, PageRenderer>();
			//Registrar.Handlers.Register<WebView, WebViewRenderer>();
		}
	}
}