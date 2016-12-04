namespace WeifenLuo.WinFormsUI.Docking
{
    using ThemeVS2015;

    /// <summary>
    /// The Basis editor "normal" theme.
    /// </summary>
    public class BasisEditorDarkTheme : VS2015ThemeBase
    {
        public BasisEditorDarkTheme()
            : base(Resources.BasisEditorDark)
        {
            mBackgroundColor = System.Drawing.Color.FromArgb(33, 33, 33); // FF212121
            mForegroundColor = System.Drawing.Color.FromArgb(160, 160, 160); // FFA0A0A0
            //mBorderColor = System.Drawing.Color.FromArgb(0);
            //mTextColor = System.Drawing.Color.FromArgb(38, 38, 38); // FF262626
        }
    }
}
