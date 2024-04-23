﻿using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Media;

namespace Sightful.Avalonia.Theme.ThemeVariants;

internal abstract class ThemeColors : ResourceDictionary
{
	protected abstract Color InnerBackground { get; }
	protected abstract Color OuterBackground { get; }
	protected abstract Color ControlBackground { get; }
	protected abstract Color PrimaryForeground { get; }
	protected abstract Color SecondaryForeground { get; }
	protected abstract Color WatermarkPrimary { get; }
	protected abstract Color WatermarkSecondary { get; }
	protected abstract Color ButtonHoverBackground { get; }
	protected abstract Color PressedButtonBackground { get; }
	protected abstract Color ToolTipForeground { get; }
	protected abstract Color LowAccentButtonBackground { get; }
	protected abstract Color LowAccentHoveredButtonBackground { get; }
	protected abstract Color LowAccentPressedButtonBackground { get; }
	protected abstract Color Accent { get; }
	protected abstract Color HighAccentButtonBackground { get; }
	protected abstract Color HighAccentHoveredButtonBackground { get; }
	protected abstract Color HighAccentButtonForeground { get; }
	protected abstract Color HighAccentPressedButtonBackground { get; }
	protected abstract Color CloseWindowHoveredButtonBackground { get; }
	protected abstract Color CloseWindowPressedButtonBackground { get; }
	protected abstract Color TextSelection { get; }
	protected abstract Color DisabledButtonBackground { get; }
	protected abstract Color HighAccentDisabledButtonBackground { get; }

	protected ThemeColors()
	{
		AddResources();
	}

	private void AddResources()
	{
		AddColor(InnerBackground);
		AddColor(OuterBackground);
		AddColor(ControlBackground);
		AddColor(PrimaryForeground);
		AddColor(SecondaryForeground);
		AddColor(WatermarkPrimary);
		AddColor(WatermarkSecondary);
		AddColor(ButtonHoverBackground);
		AddColor(PressedButtonBackground);
		AddColor(ToolTipForeground);
		AddColor(LowAccentButtonBackground);
		AddColor(LowAccentHoveredButtonBackground);
		AddColor(LowAccentPressedButtonBackground);
		AddColor(Accent);
		AddColor(HighAccentButtonBackground);
		AddColor(HighAccentHoveredButtonBackground);
		AddColor(HighAccentButtonForeground);
		AddColor(HighAccentPressedButtonBackground);
		AddColor(CloseWindowHoveredButtonBackground);
		AddColor(CloseWindowPressedButtonBackground);
		AddColor(TextSelection);
		AddColor(DisabledButtonBackground);
		AddColor(HighAccentDisabledButtonBackground);
	}

	private void AddColor(Color color, [CallerArgumentExpression(nameof(color))] string key = "")
	{
		Add(key, color);
	}
}