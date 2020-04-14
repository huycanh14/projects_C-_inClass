USE DB_DATN

GO

SELECT da.masv as N'Mã sinh viên', sv.tensv as N'Tên sinh viên', da.tenda as N'Tên đồ án', 
		CONCAT_WS(' - ',da.gvhd,gv.tengv) as 'GVHD', CONCAT_WS(' - ',da.gvpb,gv.tengv) as 'GVPB',
		lv.tenlv as N'Tên lĩnh vực', da.diem as N'Điểm', da.namtn as N'Năm TN'
FROM tbl_doan as da INNER JOIN tbl_sinhvien as sv ON da.masv = sv.masv
					INNER JOIN tbl_giangvien as gv ON da.gvhd = gv.magv
					INNER JOIN tbl_linhvuc as lv ON da.linhvuc = lv.malv
where da.tenda LIKE N'%Joomla%'
ORDER BY da.masv