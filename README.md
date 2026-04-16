# WPF Ribbon - MDI and TDI Merging

This sample shows how to perform MDI and TDI ribbon merging in a WPF application by using Syncfusion Ribbon together with DocumentContainer. A parent ribbon is defined in the main window, and each child view hosts its own ribbon with tabs, ribbon bars, and buttons that can be merged into or removed from the parent ribbon.

The sample includes both MDI and TDI modes. In each case, child views are loaded inside the DocumentContainer and associated with the parent ribbon through the `MDIParentRibbon` property. The merge and unmerge actions are triggered programmatically by calling the `Merge` and `UnMerge` methods on the parent ribbon for the selected child ribbon.

This approach is useful when building document-based WPF applications that require child documents to contribute contextual ribbon items while preserving a consistent main ribbon interface across MDI and TDI layouts. It also shows how the document container mode can be switched between MDI and TDI at runtime.

