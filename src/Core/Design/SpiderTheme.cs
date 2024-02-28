using MudBlazor;
using MudBlazor.Utilities;

namespace Spider.Design
{
    public class SpiderTheme : MudTheme
    {
        public SpiderTheme()
        {
            var defaultLight = new MudColor("#DEDEDE");
            var defaultDark = new MudColor("#010e16");

            Palette = new PaletteLight()
            {
                Primary = new MudColor("#F1815D"),
                Secondary = new MudColor("#AB3B2C"),
                Tertiary = new MudColor("#5088A6"),

                Divider = new MudColor("#a3a3a3"),
                LinesDefault = defaultDark.ColorRgbLighten(),

                Background = defaultLight,
                DrawerBackground = defaultLight.ColorLighten(0.015d),
                AppbarBackground = defaultLight,

                AppbarText = new MudColor("rgba(66, 66, 66, 1)"),

                Surface = defaultLight.ColorRgbLighten(),
                Dark = defaultDark.ColorLighten(0.015d),
            };

            PaletteDark = new PaletteDark()
            {
                Primary = new MudColor("#AB3B2C"),
                Secondary = new MudColor("#a1a09a"),
                Tertiary = new MudColor("#5088A6"),

                DividerLight = defaultLight.ColorRgbLighten(),
                LinesDefault = defaultLight.ColorRgbLighten(),

                Background = defaultDark,
                DrawerBackground = defaultDark.ColorDarken(0.015d),
                AppbarBackground = defaultDark,

                Surface = defaultDark.ColorLighten(0.015d),
                Dark = defaultDark.ColorDarken(0.015d),
            };

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"
            };
        }
    }
}
