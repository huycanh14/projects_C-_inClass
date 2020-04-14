USE DB_DATN

GO

SELECT tbl_sinhvien.masv as N'Mã sinh viên',tbl_sinhvien.tensv as N'Tên sinh viên', tbl_sinhvien.namsinh as N'Ngày sinh', 'Giới tính' =
	CASE
		WHEN tbl_sinhvien.gioitinh = 1 then N'Nữ'
		WHEN tbl_sinhvien.gioitinh = 0 then N'Nam'
		ELSE N'Không có dữ liệu'
	END,
	tbl_sinhvien.khoa as N'Khóa', tbl_chuyennganh.tencn as N'Chuyên ngành', tbl_sinhvien.email as 'Email', tbl_sinhvien.dienthoai as N'Điện thoại', tbl_sinhvien.diachi as N'Địa chỉ'
FROM tbl_sinhvien, tbl_chuyennganh
WHERE tbl_sinhvien.chuyennganh = tbl_chuyennganh.macn and (tbl_sinhvien.masv like '%111%' or tbl_sinhvien.tensv like N'%Minh')
ORDER BY tbl_sinhvien.masv