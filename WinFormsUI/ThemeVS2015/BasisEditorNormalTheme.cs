namespace WeifenLuo.WinFormsUI.Docking
{
    using ThemeVS2015;

    /// <summary>
    /// The Basis editor "normal" theme.
    /// </summary>
    public class BasisEditorNormalTheme : VS2015ThemeBase
    {
        public BasisEditorNormalTheme()
            : base(Resources.BasisEditorNormal)
        {
            mBackgroundColor = System.Drawing.Color.FromArgb(58, 58, 58); // FF3A3A3A
            mForegroundColor = System.Drawing.Color.FromArgb(185, 185, 185); // FFB9B9B9
            //mBorderColor = System.Drawing.Color.FromArgb(0);
            //mTextColor = System.Drawing.Color.FromArgb(38, 38, 38); // FF262626
        }
    }
}
