﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Sightful.Avalonia.Theme;

public sealed class DefaultTheme : Styles, IResourceNode
{
	public static readonly DirectProperty<DefaultTheme, ThemeAppearance> AppearanceProperty = AvaloniaProperty.RegisterDirect<DefaultTheme, ThemeAppearance>(
		nameof(Appearance), o => o.Appearance, (o, v) => o.Appearance = v);
	public static readonly DirectProperty<DefaultTheme, SpatialTheme> SpatialThemeProperty = AvaloniaProperty.RegisterDirect<DefaultTheme, SpatialTheme>(
		nameof(SpatialTheme), o => o.SpatialTheme, (o, v) => o.SpatialTheme = v);

	public ThemeAppearance Appearance
	{
		get => _appearance;
		set
		{
			if (SetAndRaise(AppearanceProperty, ref _appearance, value))
				value.Initialize();
		}
	}

	public SpatialTheme SpatialTheme
	{
		get => _spatialTheme;
		set
		{
			if (SetAndRaise(SpatialThemeProperty, ref _spatialTheme, value))
				value.Initialize();
		}
	}

	public DefaultTheme(IServiceProvider? serviceProvider = null)
	{
		_appearance = new ThemeAppearance();
		_appearance.Initialize();
		_spatialTheme = new SpatialTheme();
		_spatialTheme.Initialize();
		AvaloniaXamlLoader.Load(serviceProvider, this);
	}

	protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
	{
		base.OnPropertyChanged(change);
		if (change.Property == AppearanceProperty)
			Owner?.NotifyHostedResourcesChanged(ResourcesChangedEventArgs.Empty);
	}

	bool IResourceNode.TryGetResource(object key, ThemeVariant? theme, out object? value)
	{
		return _appearance.TryGetResource(key, theme, out value) || SpatialTheme.TryGetResource(key, theme, out value) || base.TryGetResource(key, theme, out value);
	}

	private ThemeAppearance _appearance;
	private SpatialTheme _spatialTheme;
}