USE DB_DATN
GO
SELECT tbl_linhvuc.tenlv as N'Lĩnh Vực', count(tbl_doan.linhvuc) as N'Số Đồ Án'
FROM tbl_linhvuc, tbl_doan
WHERE tbl_linhvuc.malv = tbl_doan.linhvuc
GROUP BY tbl_linhvuc.tenlv