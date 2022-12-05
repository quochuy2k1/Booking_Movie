export const locateText = {
    // Root
    noRowsLabel: 'Khống có dòng',
    noResultsOverlayLabel: 'Kết quả tìm kiếm không thấy.',
    errorOverlayDefaultLabel: 'Đã xảy ra lỗi.',

    // Density selector toolbar button text
    toolbarDensity: 'Mật độ',
    toolbarDensityLabel: 'Mật độ',
    toolbarDensityCompact: 'Nhỏ gọn',
    toolbarDensityStandard: 'Chuẩn',
    toolbarDensityComfortable: 'Thoải mái',

    // Văn bản nút trên toolbar chọn cột
    toolbarColumns: 'Cột',
    toolbarColumnsLabel: 'Chọn cột',

    // Lọc văn bản nút trên toolbar
    toolbarFilters: 'Bộ lọc',
    toolbarFiltersLabel: 'Hiển thị bộ lọc',
    toolbarFiltersTooltipHide: 'Ẩn bộ lọc',
    toolbarFiltersTooltipShow: 'Hiển thị bộ lọc',
    toolbarFiltersTooltipActive: (count: number) =>
        count !== 1 ? `${count} bộ lọc hoạt động` : `${count} bộ lọc hoạt động`,

    // Quick filter toolbar field
    toolbarQuickFilterPlaceholder: 'Tìm kiếm...',
    toolbarQuickFilterLabel: 'Tìm kiếm',
    toolbarQuickFilterDeleteIconLabel: 'Xoá hết',

    // Export selector toolbar button text
    toolbarExport: 'Xuất',
    toolbarExportLabel: 'Xuất',
    toolbarExportCSV: 'Tải xuống CSV file',
    toolbarExportPrint: 'Print',
    toolbarExportExcel: 'Tải xuống Excel file',

    // Văn bản bảng điều khiển cột
    columnsPanelTextFieldLabel: 'Tìm cột',
    columnsPanelTextFieldPlaceholder: 'Tiêu đề cột',
    columnsPanelDragIconLabel: 'Sắp xếp lại cột',
    columnsPanelShowAllButton: 'Hiển thị tất cả',
    columnsPanelHideAllButton: 'Ẩn tất cả',

    // Lọc văn bản bảng điều khiển
    filterPanelAddFilter: 'Thêm bộ lọc',
    filterPanelDeleteIconLabel: 'Xóa',
    filterPanelLinkOperator: 'Toán tử logic',
    filterPanelOperators: 'Toán tử', // TODO v6: đổi tên thành filterPanelOperator
    filterPanelOperatorAnd: 'Và',
    filterPanelOperatorOr: 'Hoặc',
    filterPanelColumns: 'Cột',
    filterPanelInputLabel: 'Giá trị',
    filterPanelInputPlaceholder: 'Giá trị bộ lọc',

    // Lọc văn bản toán tử
    filterOperatorContains: 'contains',
    filterOperatorEquals: 'equals',
    filterOperatorStartsWith: 'starts with',
    filterOperatorEndsWith: 'ends with',
    filterOperatorIs: 'is',
    filterOperatorNot: 'is not',
    filterOperatorAfter: 'is after',
    filterOperatorOnOrAfter: 'is on or after',
    filterOperatorBefore: 'is before',
    filterOperatorOnOrBefore: 'is on or before',
    filterOperatorIsEmpty: 'is empty',
    filterOperatorIsNotEmpty: 'is not empty',
    filterOperatorIsAnyOf: 'is any of',

    // Lọc văn bản giá trị
    filterValueAny: 'any',
    filterValueTrue: 'true',
    filterValueFalse: 'false',

    // Văn bản menu cột
    columnMenuLabel: 'Menu',
    columnMenuShowColumns: 'Hiển thị cột',
    columnMenuFilter: 'Bộ lọc',
    columnMenuHideColumn: 'Ẩn',
    columnMenuUnsort: 'Không sắp xếp',
    columnMenuSortAsc: 'Sắp xếp theo ASC',
    columnMenuSortDesc: 'Sắp xếp theo DESC',

    // Column header text
    columnHeaderFiltersTooltipActive: (count: number) =>
        count !== 1 ? `${count} bộ lọc hoạt động` : `${count} bộ lọc hoạt động`,
    columnHeaderFiltersLabel: 'Hiển thị lọc',
    columnHeaderSortIconLabel: 'Sắp xếp',

    // Rows selected footer text
    footerRowSelected: (count: number) =>
        count !== 1
            ? `${count.toLocaleString()} dòng đã được chọn`
            : `${count.toLocaleString()} dòng đã được chọn`,

    // Total row amount footer text
    footerTotalRows: 'Tổng dòng:',

    // Total visible row amount footer text
    footerTotalVisibleRows: (visibleCount: number, totalCount: number) =>
        `${visibleCount.toLocaleString()} của ${totalCount.toLocaleString()}`,

    // Văn bản lựa chọn hộp kiểm
    checkboxSelectionHeaderName: 'Lựa chọn hộp kiểm',
    checkboxSelectionSelectAllRows: 'Chọn tất cả các hàng',
    checkboxSelectionUnselectAllRows: 'Bỏ chọn tất cả các hàng',
    checkboxSelectionSelectRow: 'Chọn hàng',
    checkboxSelectionUnselectRow: 'Bỏ chọn hàng',

    // Văn bản ô Boolean
    booleanCellTrueLabel: 'có',
    booleanCellFalseLabel: 'không',

    // Ô hành động thêm văn bản
    actionsCellMore: 'thêm',

    // Văn bản ghim cột
    pinToLeft: 'Ghim sang trái',
    pinToRight: 'Ghim sang phải',
    unpin: 'Bỏ ghim',

    // Dữ liệu cây
    treeDataGroupingHeaderName: 'Nhóm',
    treeDataExpand: 'xem con',
    treeDataCollapse: 'giấu con',

    // Grouping columns
    groupingColumnHeaderName: 'Nhóm',
    groupColumn: (name: string) => `Nhóm theo ${name}`,
    unGroupColumn: (name: string) => `Dừng nhóm theo ${name}`,

    // Chính/chi tiết
    detailPanelToggle: 'Chuyển đổi bảng điều khiển chi tiết',
    expandDetailPanel: 'Mở rộng',
    crashDetailPanel: 'Thu gọn',

    // Các phím dịch thành phần cốt lõi được sử dụng
    MuiTablePagination: {},

    // Sắp xếp lại hàng văn bản
    rowReorderingHeaderName: 'Sắp xếp lại hàng',

    // tập hợp
    aggregationMenuItemHeader: 'Tổng hợp',
    aggregationFunctionLabelSum: 'sum',
    aggregationFunctionLabelAvg: 'avg',
    aggregationFunctionLabelMin: 'min',
    aggregationFunctionLabelMax: 'max',
    aggregationFunctionLabelSize: 'size',
}