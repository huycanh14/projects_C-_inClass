USE DB_DATN

GO

SELECT tbl_chuyennganh.tencn as N'Chuyên Ngành', count(tbl_sinhvien.masv) as N'Số Sinh Viên'
FROM tbl_chuyennganh, tbl_sinhvien
WHERE tbl_sinhvien.chuyennganh =  tbl_chuyennganh.macn
GROUP BY tbl_chuyennganh.tencn