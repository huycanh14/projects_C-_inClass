USE DB_DATN

GO
SELECT tbl_khoahoc.makh as N'Khóa học',  count(tbl_sinhvien.masv) as N'Số sinh viên'
FROM tbl_khoahoc, tbl_sinhvien
WHERE tbl_sinhvien.khoa = tbl_khoahoc.makh
GROUP BY tbl_khoahoc.makh