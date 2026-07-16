USE ds_cadastro_clientes;
CREATE TABLE clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    email VARCHAR(100),
    telefone VARCHAR(20),
    cidade VARCHAR(100),
    ativo BOOLEAN DEFAULT TRUE,
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO clientes
(nome, cpf, email, telefone, cidade, ativo)
VALUES
('Ana Souza', '111.111.111-11', 'ana@email.com',
'(31) 99999-1111', 'Belo Horizonte', 1),
('Carlos Oliveira', '222.222.222-22', 'carlos@email.com',
'(31) 99999-2222', 'Contagem', 1),
('Mariana Lima', '333.333.333-33', 'mariana@email.com',
'(31) 99999-3333', 'Betim', 0);