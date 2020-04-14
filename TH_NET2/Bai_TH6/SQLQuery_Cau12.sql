USE DB_DATN

GO

SELECT masv, CONCAT(masv, ' - ', tensv) as N'ten' 
FROM tbl_sinhvien
WHERE masv NOT IN (select masv from tbl_doan)