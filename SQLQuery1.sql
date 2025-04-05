CREATE DATABASE QL_GARA;
GO
USE QL_GARA;
GO

-- Tạo bảng Account
CREATE TABLE Account (
    idAccount INT IDENTITY PRIMARY KEY, 
    DisplayName NVARCHAR(100) NOT NULL, 
    UserName NVARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
    Password NVARCHAR(1000) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
    checkAdmin INT NOT NULL CHECK (checkAdmin IN (1, 2)) -- 1: Admin, 2: Staff
);
GO

CREATE TABLE Employee (
    idEmployee INT IDENTITY PRIMARY KEY,
    idAccount INT,
    FullName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Position NVARCHAR(50) NOT NULL,
    Salary DECIMAL(18,2),
    HireDate DATE DEFAULT GETDATE(),
    Status INT DEFAULT 1, -- 1: Đang làm, 0: Nghỉ
    FOREIGN KEY (idAccount) REFERENCES Account(idAccount)
);
GO

-- Tạo bảng Customer
CREATE TABLE Customer (
    idCustomer INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    sex INT,
    address NVARCHAR(255) NOT NULL,
    phoneNum VARCHAR(15) NOT NULL
);
GO

-- Tạo bảng Car
CREATE TABLE Car (
    idCar INT IDENTITY PRIMARY KEY,
    idCustomer INT,
    name NVARCHAR(100) NOT NULL,
    Hang NVARCHAR(50),
    numberCar NVARCHAR(50) NOT NULL UNIQUE,
    Color NVARCHAR(100) NOT NULL,
    Image NVARCHAR(MAX) NULL,
    FOREIGN KEY (idCustomer) REFERENCES Customer(idCustomer)
);
GO

-- Bảng Danh mục (Bảo dưỡng, Sửa chữa)
--CREATE TABLE Category (
   -- idCategory INT IDENTITY(1,1) PRIMARY KEY,
   -- Name NVARCHAR(100) NOT NULL CHECK (Name IN (N'Bảo dưỡng', N'Sửa chữa')),
   -- Description NVARCHAR(300),
   -- Type INT NOT NULL DEFAULT 1 CHECK (Type IN (1, 2)) -- 1: Bảo dưỡng, 2: Sửa chữa
--);
--GO

-- Tạo bảng _Service (chỉ dùng cho Bảo dưỡng)
CREATE TABLE _Service (
    idService INT IDENTITY PRIMARY KEY,
   -- idCategory INT NOT NULL,
    name NVARCHAR(100) NOT NULL,
    price DECIMAL(18,2) NOT NULL CHECK (price >= 0),
  --  FOREIGN KEY (idCategory) REFERENCES Category(idCategory),
);
GO
-- Tạo bảng Material (chỉ dùng cho Sửa chữa)
CREATE TABLE Material (
    idMaterial INT IDENTITY PRIMARY KEY,
  --  idCategory INT NOT NULL,
    name NVARCHAR(100) NOT NULL,
    type NVARCHAR(50) NULL,
    NoiSx NVARCHAR(50) NULL,
    quantity INT NOT NULL CHECK (quantity >= 0),
    price DECIMAL(18,2) NOT NULL CHECK (price >= 0),
    images NVARCHAR(MAX),
   -- FOREIGN KEY (idCategory) REFERENCES Category(idCategory),
);
GO

-- Bảng liên kết Service và Material (nếu cần)
CREATE TABLE Service_Material (
    idService INT,
    idMaterial INT,
    PRIMARY KEY (idService, idMaterial),
    FOREIGN KEY (idService) REFERENCES _Service(idService),
    FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial)
);
GO

-- Tạo bảng Bill
CREATE TABLE Bill (
    idBill INT IDENTITY PRIMARY KEY,
    idCustomer INT,
    idCar INT,
    DateCheckIn DATE DEFAULT GETDATE(),
    DateCheckOut DATE,
    status INT NOT NULL DEFAULT 0 CHECK (status IN (0,1)),
    FOREIGN KEY (idCustomer) REFERENCES Customer(idCustomer),
    FOREIGN KEY (idCar) REFERENCES Car(idCar),
);
GO

-- Tạo bảng BillInfo
CREATE TABLE BillInfo (
    idBillInfo INT IDENTITY PRIMARY KEY,
    idBill INT,
    idService INT NULL, -- Có thể NULL nếu chỉ dùng Material
    idMaterial INT NULL, -- Có thể NULL nếu chỉ dùng Service
    quantity INT NOT NULL CHECK (quantity > 0),
    isPaid INT DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES Bill(idBill),
    FOREIGN KEY (idService) REFERENCES _Service(idService),
    FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial),
    CONSTRAINT CHK_BillInfo_ServiceOrMaterial CHECK (
        (idService IS NOT NULL AND idMaterial IS NULL) OR
        (idService IS NULL AND idMaterial IS NOT NULL)
    )
);
go
ALTER TABLE BillInfo DROP CONSTRAINT CHK_BillInfo_ServiceOrMaterial;
ALTER TABLE BillInfo
ADD CONSTRAINT CHK_BillInfo_ServiceOrMaterial
CHECK (
    (idService IS NOT NULL OR idMaterial IS NOT NULL) -- Ít nhất một trong hai phải có giá trị
);


GO
--Bảng Lịch sử bảo dưỡng
CREATE TABLE MaintenanceHistory (
    idHistory INT IDENTITY(1,1) PRIMARY KEY,
    idCar INT FOREIGN KEY REFERENCES Car(idCar),
    MaintenanceDate DATE NOT NULL DEFAULT GETDATE(),
    NextMaintenanceDate DATE,
    CurrentKM INT NOT NULL,
    NextMaintenanceKM INT,
    TotalCost DECIMAL(18,2),
    Note NVARCHAR(1000)
);
GO

CREATE TABLE Revenue (
    idRevenue INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    totalRevenue DECIMAL(18,2) NOT NULL CHECK (totalRevenue >= 0),
    datein DATE NOT NULL DEFAULT GETDATE(),
    dateRevenue DATE NULL DEFAULT GETDATE(),
    FOREIGN KEY (idBill) REFERENCES Bill(idBill)
);
GO


INSERT INTO Account (DisplayName, UserName, Password, checkAdmin)
VALUES 
(N'Admin1','a','1',1),
(N'Nguyễn Văn A', 'nva', 'password123', 2),
(N'Trần Thị B', 'ttb', 'password456', 2);
GO
INSERT INTO Employee (idAccount, FullName, Phone, Position, Salary, HireDate, Status)
VALUES 
(2, N'Nguyễn Văn A', '0905123456', N'Nhân viên kỹ thuật', 10000000, '2023-01-15', 1),
(3, N'Trần Thị B', '0916789123', N'Nhân viên tiếp nhận', 9000000, '2023-03-20', 1);
GO
INSERT INTO Customer (name, sex, address, phoneNum)
VALUES
(N'Lê Văn Cường', 1, N'123 Đường Lê Lợi, Q1, TP.HCM', '0909123456'),
(N'Phạm Thị Dung', 0, N'456 Đường Nguyễn Huệ, Q1, TP.HCM', '0988123456'),
(N'Hoàng Minh Đức', 1, N'789 Đường CMT8, Q3, TP.HCM', '0917123456');
INSERT INTO Car (idCustomer, name, Hang, numberCar, Color, Image)
VALUES
(1, N'Toyota Camry', 'Toyota', '51A-12345', N'Đen', NULL),
(2, N'Honda CR-V', 'Honda', '51B-67890', N'Trắng', NULL),
(3, N'Ford Ranger', 'Ford', '51C-54321', N'Xám', NULL);
--INSERT INTO Category (Name, Description, Type)
--VALUES
--(N'Bảo dưỡng', N'Các dịch vụ bảo dưỡng định kỳ', 1),
--(N'Sửa chữa', N'Các dịch vụ sửa chữa, thay thế phụ tùng', 2);
INSERT INTO _Service (name, price)
VALUES
(N'Thay nhớt động cơ', 500000),
(N'Thay lọc gió', 300000),
(N'Kiểm tra hệ thống phanh', 400000),
(N'Vệ sinh điều hòa', 350000);
INSERT INTO Material (name, type, NoiSx, quantity, price, images)
VALUES
(N'Lốp xe Michelin', N'Lốp', N'Thái Lan', 20, 2500000, NULL),
(N'Má phanh trước', N'Phanh', N'Việt Nam', 15, 450000, NULL),
(N'Bugi NGK', N'Động cơ', N'Nhật Bản', 50, 150000, NULL),
(N'Bình ắc quy', N'Điện', N'Hàn Quốc', 10, 1800000, NULL);

INSERT INTO Service_Material (idService, idMaterial)
VALUES
(1, 3),
(3, 2),
(4, 4),
(1, 4),
(3, 1);
INSERT INTO Bill (idCustomer, idCar, DateCheckIn, DateCheckOut, status)
VALUES
(1, 1, '2023-05-10', '2023-05-10', 1),
(2, 2, '2023-05-12', '2023-05-13', 1),
(3, 3, '2023-05-15', NULL, 0);
INSERT INTO BillInfo (idBill, idService, idMaterial, quantity, isPaid)
VALUES
(1, 1, NULL, 1, 1),
(1, 2, NULL, 1, 1),
(2, NULL, 1, 2, 1),
(3, 3, NULL, 1, 0),
(3, NULL, 3, 4, 0);
INSERT INTO MaintenanceHistory (idCar, MaintenanceDate, NextMaintenanceDate, CurrentKM, NextMaintenanceKM, TotalCost, Note)
VALUES
(1, '2023-05-10', '2023-08-10', 15000, 20000, 800000, N'Bảo dưỡng định kỳ lần 3'),
(2, '2023-05-12', '2023-08-12', 25000, 30000, 5000000, N'Thay lốp và bảo dưỡng');
INSERT INTO Revenue (idBill, totalRevenue, datein, dateRevenue)
VALUES
(1, 800000, '2023-05-10', '2023-05-10'),
(2, 5000000, '2023-05-13', '2023-05-13');

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
--thêm thông tin khách hàng mới
create PROC InsertCustomer
	@dk int,
	@idKhach INT,
    @Ten NVARCHAR(50),
    @address NVARCHAR(50),
    @Mobile NVARCHAR(50),
    @namecar NVARCHAR(50),
    @numcar NVARCHAR(50),
	@Hang NVARCHAR(50),
    @Color NVARCHAR(50),
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
		INSERT INTO Car (idCustomer, name, Hang, numberCar, Color, Image) 
		VALUES (@idCustomer, @namecar,@Hang, @numcar, @Color, @filePath);
	END;
	IF(@dk=1)
	BEGIN 
		INSERT INTO Car (idCustomer, name,Hang, numberCar, Color, Image) 
		VALUES (@idKhach, @namecar, @Hang, @numcar, @Color, @filePath);
	END;
	
END;

go
CREATE proc EditCustomer_Car
	@idCustomer int,
	@Ten nvarchar(50),
	@sex nvarchar(20),
	@address nvarchar(50),
	@Mobile nvarchar(50),
	@nameCar NVARCHAR(100),
	@numCar NVARCHAR(50),
	@hang NVARCHAR(50),
	@color NVARCHAR(20),
	@Image NVARCHAR(MAX)
as
begin
    update Customer set
    Name = @Ten,
	sex = @sex,
    address = @address,
    phoneNum = @Mobile
    where idCustomer = @idCustomer

	update Car set
    name = @nameCar,numberCar = @numCar, Color = @color, Image = @Image, Hang =@hang
    where idCustomer = @idCustomer
end
go

create proc DeleteCustomer
@idCustomer int
as
begin
	delete Car where idCustomer = @idCustomer
    delete Customer where idCustomer = @idCustomer
end

--Thêm, Sửa, Xóa Xe
CREATE PROC USP_InsertCar
	@idCustomer int,
	@nameCar NVARCHAR(100),
	@numCar NVARCHAR(100),
	@Color NVARCHAR(20),
	@image NVARCHAR(100),
	@Hang NVARCHAR(100)
AS
BEGIN
	INSERT INTO Car (idCustomer, name, Hang, numberCar, Color, Image)
	VALUES 
	(@idCustomer, @nameCar, @Hang, @nameCar, @Color, @idCustomer)
END;

CREATE PROC USP_UpdateCar
	@idCar INT,
	@name Nvarchar(50),
	@numCar Nvarchar(50),
	@mau Nvarchar(50),
	@Hang NVARCHAR(50),
	@Image NVARCHAR(MAX) = null
AS
BEGIN
	UPDATE Car
	SET name = @name , numberCar = @numCar , Color = @mau ,Hang = @Hang,Image = @Image
	WHERE idCar = @idCar
END;

CREATE PROC DeleteCar
	@idCar INT 
AS
BEGIN
	delete Car where idCar = @idCar
END;

--Thêm, Sửa, Xóa Sản phẩm

--Phần thanh toán
create PROCEDURE USP_InsertBill
    @IdCustomer INT  
AS
BEGIN
    DECLARE @InsertedId INT;
    DECLARE @IdCar INT;

    -- Tìm idCar của khách hàng
    SELECT TOP 1 @IdCar = idCar 
    FROM Car 
    WHERE idCustomer = @IdCustomer;

    -- Nếu tìm thấy idCar, thêm hóa đơn
    IF @IdCar IS NOT NULL
    BEGIN
        INSERT INTO Bill (idCustomer, idCar, DateCheckIn, DateCheckOut, status)
        VALUES (@IdCustomer, @IdCar, GETDATE(), NULL, 0);

        -- Lấy idBill vừa được tạo
        SET @InsertedId = SCOPE_IDENTITY();  

        -- Trả về idBill
        SELECT @InsertedId AS idBill;  
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy xe, trả về -1
        SELECT -1 AS idBill;
    END
END

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

go
CREATE PROCEDURE USP_ThanhToan
    @idBill INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @TOTAL DECIMAL(18,2) = 0;
        DECLARE @DateCheckIn Date;
        DECLARE @DateCheckOut DATE = GETDATE();

        -- 1. Cập nhật ngày checkout và trạng thái hóa đơn
        UPDATE Bill
        SET DateCheckOut = @DateCheckOut, status = 1
        WHERE idBill = @idBill;

        -- 2. Trừ số lượng vật liệu trong kho (chỉ cho các vật liệu trong hóa đơn)
        UPDATE m
        SET m.quantity = m.quantity - bi.quantity
        FROM Material m
        INNER JOIN BillInfo bi ON m.idMaterial = bi.idMaterial
        WHERE bi.idBill = @idBill 
          AND bi.idMaterial IS NOT NULL
          AND m.quantity >= bi.quantity; -- Đảm bảo không âm

        -- Kiểm tra nếu có vật liệu không đủ số lượng
        IF EXISTS (
            SELECT 1 
            FROM BillInfo bi
            JOIN Material m ON bi.idMaterial = m.idMaterial
            WHERE bi.idBill = @idBill 
              AND bi.idMaterial IS NOT NULL
              AND m.quantity < bi.quantity
        )
        BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR('Một số vật liệu không đủ số lượng trong kho', 16, 1);
            RETURN;
        END

        -- 3. Tính tổng tiền hóa đơn (cả Service và Material)
        SELECT @TOTAL = ISNULL(SUM(
            CASE 
                WHEN bi.idService IS NOT NULL THEN bi.quantity * s.price
                WHEN bi.idMaterial IS NOT NULL THEN bi.quantity * m.price
                ELSE 0
            END), 0)
        FROM BillInfo bi
        LEFT JOIN _Service s ON bi.idService = s.idService
        LEFT JOIN Material m ON bi.idMaterial = m.idMaterial
        WHERE bi.idBill = @idBill;

        -- 4. Lấy ngày checkin
        SELECT @DateCheckIn = DateCheckIn FROM Bill WHERE idBill = @idBill;
        
        -- 5. Thêm doanh thu vào bảng Revenue
        INSERT INTO Revenue (idBill, totalRevenue, datein, dateRevenue)
        VALUES (@idBill, @TOTAL, @DateCheckIn, @DateCheckOut);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        -- Trả về thông báo lỗi chi tiết
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
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




Create PROC USP_UpdateCustomer
	@idCustomer INT,
	@name Nvarchar(50),
	@address Nvarchar(50),
	@phone Nvarchar(50)
AS
BEGIN
	UPDATE Customer
	SET name = @name , address = @address , phoneNum= @phone
	WHERE idCustomer = @idCustomer
END;

SELECT * FROM Account
Select * FROM Car
Select * FROM Customer
Select * FROM Revenue
Select * FROM _Service
SELECT * FROM Material
Select * FROM Service_Material

select * from Bill
select * from BillInfo

delete BillInfo
delete _Service

SELECT quantity FROM BillInfo WHERE idMaterial = @idMaterial


CREATE FUNCTION dbo.RemoveDiacritics (@input NVARCHAR(255))
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @output NVARCHAR(255) = @input;

    -- Thay thế các ký tự có dấu thành không dấu
    SET @output = REPLACE(@output, N'ÁÀÃẢẠĂẮẰẴẲẶÂẤẦẪẨẬ', 'A');
    SET @output = REPLACE(@output, N'áàãảạăắằẵẳặâấầẫẩậ', 'a');
    SET @output = REPLACE(@output, N'ÉÈẼẺẸÊẾỀỄỂỆ', 'E');
    SET @output = REPLACE(@output, N'éèẽẻẹêếềễểệ', 'e');
    SET @output = REPLACE(@output, N'ÍÌĨỈỊ', 'I');
    SET @output = REPLACE(@output, N'íìĩỉị', 'i');
    SET @output = REPLACE(@output, N'ÓÒÕỎỌÔỐỒỖỔỘƠỚỜỠỞỢ', 'O');
    SET @output = REPLACE(@output, N'óòõỏọôốồỗổộơớờỡởợ', 'o');
    SET @output = REPLACE(@output, N'ÚÙŨỦỤƯỨỪỮỬỰ', 'U');
    SET @output = REPLACE(@output, N'úùũủụưứừữửự', 'u');
    SET @output = REPLACE(@output, N'ÝỲỸỶỴ', 'Y');
    SET @output = REPLACE(@output, N'ýỳỹỷỵ', 'y');
    SET @output = REPLACE(@output, N'Đ', 'D');
    SET @output = REPLACE(@output, N'đ', 'd');

    RETURN @output;
END;






select * from Account
select * from Employee
select * from Customer
select * from Car
--select * from Category
select * from Material
select * from _Service
select * from Service_Material
select * from Customer
select * from Bill
select * from BillInfo
select * from Revenue

ALTER PROC UPS_Material
	@dk INT,  
	@idService INT = NULL,  
	@idMaterial INT = NULL,  
	@name NVARCHAR(50),  
	@type NVARCHAR(20),  
	@PhanLoai NVARCHAR(50),  
	@noiSx NVARCHAR(50),  
	@quantity INT,  
	@price DECIMAL(18,2),  
	@image NVARCHAR(MAX)  
AS  
BEGIN  
	SET NOCOUNT ON;

	-- Thêm mới dữ liệu
	IF (@dk = 0)  
	BEGIN  
		DECLARE @newServiceID INT, @newMaterialID INT;

		-- Thêm vào bảng _Service nếu chưa tồn tại
		IF NOT EXISTS (SELECT 1 FROM _Service WHERE name = @PhanLoai)
		BEGIN
			INSERT INTO _Service (name, price) VALUES (@PhanLoai, 0);
			SET @newServiceID = SCOPE_IDENTITY();  
		END  
		ELSE  
		BEGIN  
			SELECT @newServiceID = idService FROM _Service WHERE name = @PhanLoai;  
		END  

		-- Thêm vào bảng Material  
		INSERT INTO Material (name, type, NoiSx, quantity, price, images)  
		VALUES (@name, @type, @noiSx, @quantity, @price, @image);
		SET @newMaterialID = SCOPE_IDENTITY();

		-- Thêm vào bảng liên kết Service_Material
		IF NOT EXISTS (SELECT 1 FROM Service_Material WHERE idService = @newServiceID AND idMaterial = @newMaterialID)
		BEGIN
			INSERT INTO Service_Material (idService, idMaterial)  
			VALUES (@newServiceID, @newMaterialID);
		END  
	END;  

	-- Cập nhật dữ liệu
	IF (@dk = 1)  
	BEGIN  
		IF EXISTS (SELECT 1 FROM _Service WHERE idService = @idService)  
		BEGIN  
			UPDATE _Service SET name = @PhanLoai WHERE idService = @idService;  
		END  

		IF EXISTS (SELECT 1 FROM Material WHERE idMaterial = @idMaterial)  
		BEGIN  
			UPDATE Material  
			SET name = @name, type = @type, NoiSx = @noiSx, quantity = @quantity, price = @price, images = @image  
			WHERE idMaterial = @idMaterial;  
		END  
	END;  

	-- Xóa dữ liệu
	IF (@dk = 2)  
	BEGIN  
			DELETE FROM BillInfo WHERE idMaterial = @idMaterial; 
			DELETE FROM Service_Material WHERE idMaterial = @idMaterial AND idService = @idService;  
			--DELETE FROM _Service WHERE idMaterial = @idMaterial;
			DELETE FROM Material WHERE idMaterial = @idMaterial;
	END;  
END;


CREATE PROC USP_FixMaterial
	@idMaterial INT,
	@name NVARCHAR(100),
	@type NVARCHAR(50),
	@NoiSx NVARCHAR(50),
	@quantity INT,
	@price DECIMAL(18,2),
	@image NVARCHAR(MAX)
AS
BEGIN
	UPDATE Material  
	SET name = @name, type = @type, NoiSx = @noiSx, quantity = @quantity, price = @price, images = @image  
	WHERE idMaterial = @idMaterial;  
END;

select * from Material
select * from Service_Material

select s.idService
from _Service s,Material m, Service_Material ms 
where s.idService = ms.idService and ms.idMaterial = m.idMaterial  and m.idMaterial = @idMaterial

