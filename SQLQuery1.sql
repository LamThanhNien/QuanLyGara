CREATE DATABASE QL_GARA;
GO
USE QL_GARA;
GO

-- Tạo bảng Account
CREATE TABLE Account (
    id INT IDENTITY PRIMARY KEY, 
    DisplayName NVARCHAR(100) NOT NULL, 
    UserName NVARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL, -- Phân biệt chữ hoa và thường
    Password NVARCHAR(1000) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,       -- Phân biệt chữ hoa và thường
    checkAdmin INT NOT NULL CHECK (checkAdmin IN (1, 2)) -- 1: Admin, 2: Staff
);
GO

-- Tạo bảng Customer
CREATE TABLE Customer (
    idCustomer INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    address NVARCHAR(255) NOT NULL,
    phoneNum VARCHAR(15) NOT NULL
);
GO

-- Tạo bảng Car
CREATE TABLE Car (
    idCar INT IDENTITY PRIMARY KEY,
    idCustomer INT,
    name NVARCHAR(100) NOT NULL,
    numberCar NVARCHAR(50) NOT NULL UNIQUE,
    logo NVARCHAR(100) NOT NULL,
	ImageBase64 NVARCHAR(MAX) NOT NULL, -- Lưu ảnh dưới dạng chuỗi Base64
    FOREIGN KEY (idCustomer) REFERENCES Customer(idCustomer)
);

-- Tạo bảng _Service
CREATE TABLE _Service (
    idService INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE,
    price DECIMAL(18,2) NOT NULL CHECK (price >= 0)
);
GO

CREATE TABLE Material (
    idMaterial INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    quantity INT NOT NULL CHECK (quantity >= 0),
    price DECIMAL(18,2) NOT NULL CHECK (price >= 0),
    idService INT, 
    FOREIGN KEY (idService) REFERENCES _Service(idService)
);


CREATE TABLE Service_Material (
    idService INT,
    idMaterial INT,
    PRIMARY KEY (idService, idMaterial),
    FOREIGN KEY (idService) REFERENCES _Service(idService),
    FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial)
);


-- Tạo bảng Bill
CREATE TABLE Bill (
    idBill INT IDENTITY PRIMARY KEY,
    idCustomer INT,
    idCar INT,
    DateCheckIn DATE,
    DateCheckOut DATE,
    status INT NOT NULL DEFAULT 0 CHECK (status IN (0,1)),
    FOREIGN KEY (idCustomer) REFERENCES Customer(idCustomer),
    FOREIGN KEY (idCar) REFERENCES Car(idCar)
);
GO

-- Tạo bảng BillInfo
CREATE TABLE BillInfo (
    idBillInfo INT IDENTITY PRIMARY KEY,
    idBill INT,
    idService INT,
    idMaterial INT, -- Thêm cột này để liên kết trực tiếp vật tư sử dụng
    quantity INT NOT NULL CHECK (quantity > 0),
	isPaid INT DEFAULT 0
    FOREIGN KEY (idBill) REFERENCES Bill(idBill),
    FOREIGN KEY (idService) REFERENCES _Service(idService),
    FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial)
);


CREATE TABLE Revenue (
    idRevenue INT IDENTITY PRIMARY KEY, -- Khóa chính, tự động tăng
    idBill INT NOT NULL,                -- Liên kết với bảng Bill
    totalRevenue DECIMAL(18,2) NOT NULL CHECK (totalRevenue >= 0), -- Tổng doanh thu (không âm)
    dateRevenue DATE NOT NULL,          -- Ngày ghi nhận doanh thu
    FOREIGN KEY (idBill) REFERENCES Bill(idBill) -- Khóa ngoại đến bảng Bill
);
GO

INSERT INTO Account (DisplayName, UserName, Password, checkAdmin) VALUES
('Admin1','a','1',1),
(N'Quản trị viên phụ', N'adminphu', N'MậtKhẩu@456', 1),
(N'Nguyễn Văn Ánh', N'nvanh', N'BảoMật@789', 2),
(N'Trần Thị Bích', N'ttbich', N'AnToàn@321', 2);

INSERT INTO Customer (name, address, phoneNum) VALUES
(N'Nguyễn Văn Ánh', N'123 Lê Lợi, TP.HCM', '0909123456'),
(N'Trần Thị Bích', N'456 Trần Hưng Đạo, Hà Nội', '0988765432'),
(N'Phạm Văn Cường', N'789 Nguyễn Trãi, TP.HCM', '0912345678');


INSERT INTO Car (idCustomer, name, numberCar, logo, ImageBase64) VALUES
(1, N'Toyota Camry', N'51F-12345', N'Toyota', ''),
(1, N'Honda Civic', N'30G-67890', N'Honda', ''),
(2, N'Ford Ranger', N'29A-54321', N'Ford', ''),
(3, N'BMW Series 3', N'45B-11223', N'BMW', '');


INSERT INTO _Service (name, price) VALUES
(N'Thay dầu', 200000),      -- 200.000 VND
(N'Xoay bánh', 150000),      -- 150.000 VND
(N'Kiểm tra phanh', 250000), -- 250.000 VND
(N'Kiểm tra ắc quy', 120000);  -- 120.000 VND


INSERT INTO Material (name, quantity, price, idService) VALUES
(N'Lọc dầu', 50, 50000, 1),       -- 50.000 VND
(N'Lọc gió', 30, 70000, 1),       -- 70.000 VND
(N'Bánh xe', 20, 800000, 2),       -- 800.000 VND
(N'Bộ má phanh', 40, 300000, 3),   -- 300.000 VND
(N'Ắc quy', 25, 600000, 4);        -- 600.000 VND


INSERT INTO Service_Material (idService, idMaterial) VALUES
(1, 1),  -- Thay dầu sử dụng Lọc dầu
(1, 2),  -- Thay dầu sử dụng Lọc gió
(2, 3),  -- Xoay bánh sử dụng Bánh xe
(3, 4),  -- Kiểm tra phanh sử dụng Bộ má phanh
(4, 5);  -- Kiểm tra ắc quy sử dụng Ắc quy


INSERT INTO Bill (idCustomer, idCar, DateCheckIn, DateCheckOut, status) VALUES
(1, 1, '2025-03-01', '2025-03-01', 1),
(2, 3, '2025-03-02', '2025-03-03', 0),
(3, 4, '2025-03-04', '2025-03-04', 1);


INSERT INTO BillInfo (idBill, idService, idMaterial, quantity) VALUES
(1, 1, 1, 1),  -- Hóa đơn 1: Thay dầu với 1 Lọc dầu
(1, 1, 2, 1),  -- Hóa đơn 1: Thay dầu với 1 Lọc gió
(1, 2, 3, 4),  -- Hóa đơn 1: Xoay bánh với 4 Bánh xe (ví dụ xe cần 4 bánh)
(2, 3, 4, 2),  -- Hóa đơn 2: Kiểm tra phanh với 2 Bộ má phanh
(3, 4, 5, 1);  -- Hóa đơn 3: Kiểm tra ắc quy với 1 Ắc quy


INSERT INTO Revenue (idBill, totalRevenue, dateRevenue) VALUES
(1, 200000 + 200000 + 150000 + (800000 * 4), '2025-03-01'),
(2, 250000 + (300000 * 2), '2025-03-03'),
(3, 120000 + 600000, '2025-03-04');


-- Chèn dữ liệu vào bảng Revenue từ các hóa đơn đã thanh toán
INSERT INTO Revenue (idBill, totalRevenue, dateRevenue)
SELECT 
    B.idBill, 
    SUM(BI.quantity * S.price) AS totalRevenue, 
    B.DateCheckOut AS dateRevenue
FROM 
    Bill B
JOIN 
    BillInfo BI ON B.idBill = BI.idBill
JOIN 
    _Service S ON BI.idService = S.idService
WHERE 
    B.status = 1 -- Chỉ tính các hóa đơn đã thanh toán
GROUP BY 
    B.idBill, B.DateCheckOut;



--phần đăng nhập
Create Proc USP_login
@UserName nvarchar(100),@Password nvarchar(100)
as
Begin 
	SELECT COUNT(*)
	FROM Account AC
    WHERE UserName COLLATE SQL_Latin1_General_CP1_CS_AS = @UserName
      AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password ;
End
go

--phần hiển thị cho khách hàng
SELECT cs.name,cs.address,cs.phoneNum, c.name as namecar,c.numberCar,c.logo
FROM Customer cs 
INNER JOIN Car c ON cs.idCustomer = c.idCustomer;

--phần hiển thị cho car
SELECT cs.name, c.name as namecar,c.numberCar,cs.address,cs.phoneNum, c.ImageBase64
FROM Customer cs 
INNER JOIN Car c ON cs.idCustomer = c.idCustomer;

--thêm thông tin khách hàng mới
create PROC InsertCustomer
	@dk int,
	@idKhach INT,
    @Ten NVARCHAR(50),
    @address NVARCHAR(50),
    @Mobile NVARCHAR(50),
    @namecar NVARCHAR(50),
    @numcar NVARCHAR(50),
    @logo NVARCHAR(50),
    @filePath NVARCHAR(MAX)
AS
BEGIN
    DECLARE @idCustomer INT;
	--DECLARE @idCar INT;
    IF EXISTS (SELECT 1 FROM Car WHERE numberCar = @numcar)
    BEGIN
        RETURN;
    END
	IF(@dk=0)
	BEGIN
		INSERT INTO Customer (name, address, phoneNum) 
		VALUES (@Ten, @address, @Mobile);
		SET @idCustomer = SCOPE_IDENTITY(); 
		INSERT INTO Car (idCustomer, name, numberCar, logo, ImageBase64) 
		VALUES (@idCustomer, @namecar, @numcar, @logo, @filePath);
	END;
	IF(@dk=1)
	BEGIN 
		INSERT INTO Car (idCustomer, name, numberCar, logo, ImageBase64) 
		VALUES (@idKhach, @namecar, @numcar, @logo, @filePath);
	END;
	
END;

--drop proc InsertCustomer
go
create proc EditCustomer
@idCustomer int,
@Ten nvarchar(50),
@address nvarchar(50),
@Mobile nvarchar(50)
as
begin
    update Customer set
    Name = @Ten,
    address = @address,
    phoneNum = @Mobile
    where idCustomer = @idCustomer
end
go
create proc DeleteCustomer
@idCustomer int
as
begin
    delete Customer where idCustomer = @idCustomer
end


SELECT * FROM Account
Select * FROM Car
Select * FROM Customer
Select * FROM _Service
Select * FROM Revenue
SELECT * FROM Material
select * from Bill
select * from BillInfo

-- tính thành tiền
SELECT s.name, s.price, bi.quantity, b.idBill, (bi.quantity* s.price) AS TotalAmount
FROM Bill b
JOIN BillInfo bi ON b.idBill = bi.idBill
JOIN _Service s ON bi.idService = s.idService
JOIN Material m ON bi.idMaterial = m.idMaterial
WHERE b.idBill = @id


Create PROCEDURE USP_InsertBill
    @IdCustomer INT  
AS
BEGIN
    DECLARE @InsertedId INT;
    DECLARE @IdCar INT;
    SELECT TOP 1 @IdCar = idCar 
    FROM Car 
    WHERE idCustomer = @IdCustomer;

    -- 🔹 Nếu tìm thấy idCar, thêm hóa đơn
    IF @IdCar IS NOT NULL
    BEGIN
        INSERT INTO Bill (idCustomer, idCar, DateCheckIn, DateCheckOut, status)
        VALUES (@IdCustomer, @IdCar, GETDATE(), NULL, 0);

        SET @InsertedId = SCOPE_IDENTITY();  

        SELECT @InsertedId AS idBill;  
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy xe, trả về -1
        SELECT -1 AS idBill;
    END
END


select MAX(idBill) from Bill


CREATE PROCEDURE USP_InsertBillInfo
    @IdBill INT, 
    @IdService INT, 
    @IdMaterial INT, 
    @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT;
    DECLARE @quantity INT = 1;

    -- Kiểm tra xem bản ghi đã tồn tại trong BillInfo chưa
    SELECT @isExitsBillInfo = idBillInfo, @quantity = quantity
    FROM BillInfo  
    WHERE idBill = @IdBill AND idService = @IdService AND idMaterial = @IdMaterial;

    IF (@isExitsBillInfo IS NOT NULL) 
    BEGIN
        -- Nếu tồn tại, cập nhật số lượng
        DECLARE @newCount INT = @quantity + @count;
        IF (@newCount > 0)
            UPDATE BillInfo SET quantity = @newCount 
            WHERE idBill = @IdBill AND idService = @IdService AND idMaterial = @IdMaterial;
        ELSE
            DELETE FROM BillInfo 
            WHERE idBill = @IdBill AND idService = @IdService AND idMaterial = @IdMaterial;
    END
    ELSE
    BEGIN
        -- Nếu chưa tồn tại, thêm mới
        INSERT INTO BillInfo (idBill, idService, idMaterial, quantity)
        VALUES (@IdBill, @IdService, @IdMaterial, @count);
    END
END;


SELECT * FROM Bill  -- Kiểm tra hóa đơn có tồn tại không
SELECT * FROM BillInfo; -- Kiểm tra dữ liệu trong BillInfo
SELECT * FROM _Service; -- Kiểm tra danh sách dịch vụ
SELECT * FROM Material; -- Kiểm tra danh sách vật tư


SELECT top 1 idBill + 1 FROM Bill ORDER BY idBill DESC



select c.name, car.name
from Customer c
join Car on c.idCustomer = Car.idCustomer

SELECT 
    (bi.quantity* s.price) AS totalPrice
FROM Bill b
JOIN BillInfo bi ON b.idBill = bi.idBill
JOIN _Service s ON bi.idService = s.idService
JOIN Material m ON bi.idMaterial = m.idMaterial
where b.idBill = 4

select * from bill

CREATE PROC USP_ThanhToan
    @idBill INT
AS
BEGIN
        UPDATE Bill
        SET DateCheckOut = GETDATE(), status = 1
        WHERE idBill = @idBill;
END;

CREATE PROC USP_UpdateBillInfo
	@stt int,
    @idBill INT,
	@IdMaterial int
AS
BEGIN
	IF(@stt=1)
	BEGIN
        UPDATE BillInfo
        SET isPaid = 1
        WHERE idBill = @idBill;
	END;
	IF(@stt=0)
	BEGIN
	    UPDATE BillInfo
        SET isPaid = 0
        WHERE idBill = @idBill AND idMaterial = @IdMaterial;
	END;
END;

CREATE PROC USP_lastBill
	@idBill int
AS
BEGIN
	
	SELECT sum(bi.quantity* s.price) AS Total from Bill B 
	JOIN BillInfo BI ON B.idBill = BI.idBill
	JOIN _Service S ON BI.idService = S.idService
	WHERE BI.isPaid = 0 and B.idBill  = @idBill;
END;