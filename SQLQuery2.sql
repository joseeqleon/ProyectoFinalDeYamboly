-- Crear base de datos
CREATE DATABASE PruebaHeladeriaBaseDatosYamboly;
GO
USE PruebaHeladeriaBaseDatosYamboly;
GO

-- Tabla Ubigeo
CREATE TABLE Ubigeo (
    UbigeoID NVARCHAR(10) PRIMARY KEY,
    Departamento NVARCHAR(100),
    Provincia NVARCHAR(100),
    Distrito NVARCHAR(100)
);

-- Tabla Empresa
CREATE TABLE Empresa (
    EmpresaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    RUC NVARCHAR(20),
    UbigeoID NVARCHAR(10),
    Estado BIT,

    FOREIGN KEY (UbigeoID) REFERENCES Ubigeo(UbigeoID)
);

-- Tabla Producto
CREATE TABLE Producto (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Producto NVARCHAR(100),
    Descripcion NVARCHAR(200),
    Estado BIT
);

-- Tabla Presentacion
CREATE TABLE Presentacion (
    PresentacionID INT PRIMARY KEY IDENTITY(1,1),
    ProductoID INT FOREIGN KEY REFERENCES Producto(ProductoID),
    Presentacion NVARCHAR(100),
    Precio DECIMAL(10,2),
    Cantidad INT, 
    Estado BIT
);

-- Tabla Pedido
CREATE TABLE Pedido (
    PedidoID INT PRIMARY KEY IDENTITY(1,1),
    EmpresaID INT FOREIGN KEY REFERENCES Empresa(EmpresaID),
    ProductoID INT FOREIGN KEY REFERENCES Producto(ProductoID),
    PresentacionID INT FOREIGN KEY REFERENCES Presentacion(PresentacionID),
    Cantidad INT,
    FechaPedido DATETIME,
    Estado BIT
);


-- Tabla Venta
CREATE TABLE Venta (
    VentaID INT PRIMARY KEY IDENTITY(1,1),
    PedidoID INT FOREIGN KEY REFERENCES Pedido(PedidoID),
    FechaVenta DATETIME,
    Estado BIT
);
GO


--Tabla Metodo de Pago
CREATE TABLE MetodoDePago (
    MetodoPagoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Estado BIT DEFAULT 1
);

-- Inserta métodos de pago en Perú
INSERT INTO MetodoDePago (Nombre) VALUES
('Tarjeta de Crédito - Visa'),
('Tarjeta de Débito - Interbank'),
('Yape'),
('Plin'),
('Transferencia Bancaria - BCP'),
('Pago en Efectivo');
GO

-- Tabla Comprobante de pago
CREATE TABLE ComprobanteDePago (
    ComprobanteID INT PRIMARY KEY IDENTITY(1,1),
    PedidoID INT FOREIGN KEY REFERENCES Pedido(PedidoID),
    MetodoPagoID INT FOREIGN KEY REFERENCES MetodoDePago(MetodoPagoID),
    FechaEntrega DATE NOT NULL,
    Estado BIT DEFAULT 1
);
GO

-- ========================
-- CRUD - EMPRESA
-- ========================

-- Listar Empresa
CREATE OR ALTER PROCEDURE spListarEmpresa
AS
BEGIN
    SELECT 
        e.EmpresaID,
        e.Nombre,
        e.RUC,
        u.UbigeoID,
        u.Departamento,
        u.Provincia,
        u.Distrito,
        e.Estado
    FROM Empresa e
    INNER JOIN Ubigeo u ON e.UbigeoID = u.UbigeoID
    WHERE e.Estado = 1
END


-- Registrar Empresa
CREATE OR ALTER PROCEDURE spRegistrarEmpresa
    @Nombre NVARCHAR(100),
    @RUC NVARCHAR(20),
    @UbigeoID NVARCHAR(10)
AS
BEGIN
    INSERT INTO Empresa (Nombre, RUC, UbigeoID, Estado)
    VALUES (@Nombre, @RUC, @UbigeoID, 1)
END


-- Editar Empresa
CREATE OR ALTER PROCEDURE spEditarEmpresa
    @EmpresaID INT,
    @Nombre NVARCHAR(100),
    @RUC NVARCHAR(20),
    @UbigeoID NVARCHAR(10)
AS
BEGIN
    UPDATE Empresa
    SET Nombre = @Nombre,
        RUC = @RUC,
        UbigeoID = @UbigeoID
    WHERE EmpresaID = @EmpresaID
END


-- Eliminar lógica Empresa
CREATE OR ALTER PROCEDURE spEliminarEmpresa
    @EmpresaID INT
AS
BEGIN
    UPDATE Empresa
    SET Estado = 0
    WHERE EmpresaID = @EmpresaID
END


-- Lista de Ubigeo
INSERT INTO Ubigeo (UbigeoID, Departamento, Provincia, Distrito) VALUES
('130101', 'La Libertad', 'Trujillo', 'Trujillo'),
('130102', 'La Libertad', 'Trujillo', 'El Porvenir'),
('130103', 'La Libertad', 'Trujillo', 'Florencia de Mora'),
('130104', 'La Libertad', 'Trujillo', 'Huanchaco'),
('130105', 'La Libertad', 'Trujillo', 'La Esperanza'),
('130106', 'La Libertad', 'Trujillo', 'Laredo'),
('130107', 'La Libertad', 'Trujillo', 'Moche'),
('130108', 'La Libertad', 'Trujillo', 'Poroto'),
('130109', 'La Libertad', 'Trujillo', 'Salaverry'),
('130110', 'La Libertad', 'Trujillo', 'Simbal'),
('130111', 'La Libertad', 'Trujillo', 'Víctor Larco Herrera'),

('130201', 'La Libertad', 'Ascope', 'Ascope'),
('130202', 'La Libertad', 'Ascope', 'Chicama'),
('130203', 'La Libertad', 'Ascope', 'Chocope'),
('130204', 'La Libertad', 'Ascope', 'Magdalena de Cao'),
('130205', 'La Libertad', 'Ascope', 'Paiján'),
('130206', 'La Libertad', 'Ascope', 'Rázuri'),
('130207', 'La Libertad', 'Ascope', 'Santiago de Cao'),

('130401', 'La Libertad', 'Chepén', 'Chepén'),
('130402', 'La Libertad', 'Chepén', 'Pacanga'),
('130403', 'La Libertad', 'Chepén', 'Pueblo Nuevo'),

('130701', 'La Libertad', 'Pacasmayo', 'San Pedro de Lloc'),
('130702', 'La Libertad', 'Pacasmayo', 'Guadalupe'),
('130703', 'La Libertad', 'Pacasmayo', 'Jequetepeque'),
('130704', 'La Libertad', 'Pacasmayo', 'Pacasmayo'),
('130705', 'La Libertad', 'Pacasmayo', 'San José'),

('130901', 'La Libertad', 'Sánchez Carrión', 'Huamachuco'),
('130902', 'La Libertad', 'Sánchez Carrión', 'Chugay'),
('130903', 'La Libertad', 'Sánchez Carrión', 'Cochabamba'),
('130904', 'La Libertad', 'Sánchez Carrión', 'Curgos'),
('130905', 'La Libertad', 'Sánchez Carrión', 'Marcabal'),
('130906', 'La Libertad', 'Sánchez Carrión', 'Sanagorán'),
('130907', 'La Libertad', 'Sánchez Carrión', 'Sarín'),
('130908', 'La Libertad', 'Sánchez Carrión', 'Sartimbamba'),

('131001', 'La Libertad', 'Santiago de Chuco', 'Santiago de Chuco'),
('131002', 'La Libertad', 'Santiago de Chuco', 'Angasmarca'),
('131003', 'La Libertad', 'Santiago de Chuco', 'Cachicadán'),
('131004', 'La Libertad', 'Santiago de Chuco', 'Mollebamba'),
('131005', 'La Libertad', 'Santiago de Chuco', 'Mollepata'),
('131006', 'La Libertad', 'Santiago de Chuco', 'Quiruvilca'),
('131007', 'La Libertad', 'Santiago de Chuco', 'Santa Cruz de Chuca'),
('131008', 'La Libertad', 'Santiago de Chuco', 'Sitabamba');


-- ========================
-- CRUD - PRODUCTO
-- ========================

-- Listar Producto
CREATE PROCEDURE spListarProducto AS
SELECT * FROM Producto WHERE Estado = 1;
GO

-- Registrar Producto
CREATE PROCEDURE spRegistrarProducto
@Producto NVARCHAR(100), @Descripcion NVARCHAR(200)
AS
INSERT INTO Producto (Producto, Descripcion, Estado)
VALUES (@Producto, @Descripcion, 1);
GO

-- Editar Producto
CREATE PROCEDURE spEditarProducto
@ProductoID INT, @Producto NVARCHAR(100), @Descripcion NVARCHAR(200)
AS
UPDATE Producto
SET Producto = @Producto, Descripcion = @Descripcion
WHERE ProductoID = @ProductoID;
GO

-- Eliminar lógica Producto + Presentaciones asociadas
CREATE PROCEDURE spEliminarProducto
@ProductoID INT
AS
BEGIN
    -- Eliminar (lógico) producto
    UPDATE Producto SET Estado = 0 WHERE ProductoID = @ProductoID;

    -- Eliminar (lógico) presentaciones asociadas
    UPDATE Presentacion SET Estado = 0 WHERE ProductoID = @ProductoID;
END;
GO

-- ========================
-- CRUD - PRESENTACION
-- ========================

-- Listar Presentación
CREATE PROCEDURE spListarPresentacion
@ProductoID INT
AS
SELECT * FROM Presentacion
WHERE Estado = 1 AND ProductoID = @ProductoID;
GO



-- Registrar Presentación
CREATE PROCEDURE spRegistrarPresentacion
@ProductoID INT,
@Presentacion NVARCHAR(100),
@Precio DECIMAL(10,2),
@Cantidad INT
AS
INSERT INTO Presentacion (ProductoID, Presentacion, Precio, Cantidad, Estado)
VALUES (@ProductoID, @Presentacion, @Precio, @Cantidad, 1);
GO


-- Editar Presentación
CREATE PROCEDURE spEditarPresentacion
@PresentacionID INT,
@Presentacion NVARCHAR(100),
@Precio DECIMAL(10,2),
@Cantidad INT
AS
UPDATE Presentacion
SET Presentacion = @Presentacion,
    Precio = @Precio,
    Cantidad = @Cantidad
WHERE PresentacionID = @PresentacionID;
GO

-- Eliminar lógica Presentación
CREATE PROCEDURE spEliminarPresentacion
@PresentacionID INT
AS
UPDATE Presentacion
SET Estado = 0
WHERE PresentacionID = @PresentacionID;
GO

-- ListarPresentacionGoblal
CREATE OR ALTER PROCEDURE spListarPresentacionesGlobal
AS
SELECT p.PresentacionID, p.ProductoID, prod.Producto, p.Presentacion, p.Precio, p.Cantidad, p.Estado
FROM Presentacion p
JOIN Producto prod ON p.ProductoID = prod.ProductoID
WHERE p.Estado = 1;
GO

-- ========================
-- CORE - PEDIDO
-- ========================

-- Listar Pedido
CREATE OR ALTER PROCEDURE spListarPedido
AS
SELECT 
    p.PedidoID,
    p.EmpresaID,
    e.Nombre AS EmpresaNombre,
    p.ProductoID,
    p.PresentacionID,
    p.Cantidad,
    p.FechaPedido,
    p.Estado
FROM Pedido p
JOIN Empresa e ON p.EmpresaID = e.EmpresaID
WHERE p.Estado = 1;
GO


-- Registrar Pedido
CREATE OR ALTER PROCEDURE spRegistrarPedido
@EmpresaID INT,
@ProductoID INT,
@PresentacionID INT,
@Cantidad INT,
@FechaPedido DATETIME
AS
BEGIN
    DECLARE @StockActual INT;

    SELECT @StockActual = Cantidad
    FROM Presentacion
    WHERE PresentacionID = @PresentacionID;

    IF @StockActual < @Cantidad
    BEGIN
        RAISERROR('Stock insuficiente para esta presentación.', 16, 1);
        RETURN;
    END

    INSERT INTO Pedido (EmpresaID, ProductoID, PresentacionID, Cantidad, FechaPedido, Estado)
    VALUES (@EmpresaID, @ProductoID, @PresentacionID, @Cantidad, @FechaPedido, 1);

    UPDATE Presentacion
    SET Cantidad = Cantidad - @Cantidad
    WHERE PresentacionID = @PresentacionID;
END;
GO

-- Anular Pedido
CREATE OR ALTER PROCEDURE spAnularPedido
@PedidoID INT
AS
BEGIN
    DECLARE @PresentacionID INT, @Cantidad INT;

    IF NOT EXISTS (SELECT 1 FROM Pedido WHERE PedidoID = @PedidoID AND Estado = 1)
    BEGIN
        RAISERROR('El pedido no existe o ya está anulado.', 16, 1);
        RETURN;
    END

    SELECT @PresentacionID = PresentacionID, @Cantidad = Cantidad
    FROM Pedido WHERE PedidoID = @PedidoID;

    UPDATE Presentacion
    SET Cantidad = Cantidad + @Cantidad
    WHERE PresentacionID = @PresentacionID;

    UPDATE Pedido
    SET Estado = 0
    WHERE PedidoID = @PedidoID;
END;
GO


-- Listar Pedido Por Fecha
CREATE PROCEDURE spListarPedidoPorFecha
@Fecha DATETIME
AS
SELECT * FROM Pedido
WHERE Estado = 1 AND CAST(FechaPedido AS DATE) = CAST(@Fecha AS DATE)
ORDER BY FechaPedido DESC;
GO

-- ========================
-- CORE - VENTA
-- ========================

-- Listar Venta
CREATE PROCEDURE spListarVenta AS
SELECT * FROM Venta WHERE Estado = 1;
GO

-- Registrar Venta
CREATE OR ALTER PROCEDURE spRegistrarVenta
@PedidoID INT,
@FechaVenta DATETIME
AS
BEGIN
    INSERT INTO Venta (PedidoID, FechaVenta, Estado)
    VALUES (@PedidoID, @FechaVenta, 1);
END;


-- Anular Venta
CREATE OR ALTER PROCEDURE spAnularVenta
@VentaID INT
AS
BEGIN
    DECLARE @PedidoID INT, @PresentacionID INT, @Cantidad INT;

    SELECT @PedidoID = PedidoID FROM Venta WHERE VentaID = @VentaID;
    SELECT @PresentacionID = PresentacionID, @Cantidad = Cantidad
    FROM Pedido WHERE PedidoID = @PedidoID;

    -- Reponer stock
    UPDATE Presentacion
    SET Cantidad = Cantidad + @Cantidad
    WHERE PresentacionID = @PresentacionID;

    -- Anular venta
    UPDATE Venta
    SET Estado = 0
    WHERE VentaID = @VentaID;
END;



-- ========================
-- CORE - PAGO
-- ========================

-- Listar Pago
CREATE PROCEDURE spListarPago
AS
BEGIN
    SELECT cp.ComprobanteID, cp.PedidoID, mp.Nombre AS MetodoPago, cp.FechaEntrega, cp.Estado
    FROM ComprobanteDePago cp
    JOIN MetodoDePago mp ON cp.MetodoPagoID = mp.MetodoPagoID
    WHERE cp.Estado = 1
    ORDER BY cp.ComprobanteID DESC;
END;


-- Registrar Pago
CREATE PROCEDURE spRegistrarPago
@PedidoID INT,
@MetodoPagoID INT,
@FechaEntrega DATE
AS
BEGIN
    INSERT INTO ComprobanteDePago (PedidoID, MetodoPagoID, FechaEntrega)
    VALUES (@PedidoID, @MetodoPagoID, @FechaEntrega);
END;



--Existencia de Pago
CREATE PROCEDURE spExistePagoPorPedido
@PedidoID INT
AS
BEGIN
    SELECT COUNT(*) FROM ComprobanteDePago
    WHERE PedidoID = @PedidoID AND Estado = 1
END