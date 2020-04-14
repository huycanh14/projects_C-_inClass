USE DB_DATN

GO

INSERT INTO tbl_sinhvien (masv, tensv, namsinh, gioitinh, khoa, chuyennganh, email, dienthoai, diachi)
VALUES (1121050069, N'Nguyễn Thị Nguyệt', '10-09-1993', 1, 56, 1, 'nguyetit.humg@gmail.com', 0987666564, N'Lai Châu')

GO

INSERT INTO tbl_giangvien
VALUES (080511, N'Trương Xuân Bình', '1984-05-13', 0, N'Thạc sĩ', 'truongxuanbinh@humg.edu.vn', 0981234567, N'Bộ môn Tin học Địa chất')

GO

INSERT INTO tbl_doan
VALUES (1121050069, N'Ứng dụng phần mềm Ventsim tính toán thiết kế mạng thông gió mỏ Bình Minh – Thành Công', '080506', '080506', 1, 8.1, 2016)