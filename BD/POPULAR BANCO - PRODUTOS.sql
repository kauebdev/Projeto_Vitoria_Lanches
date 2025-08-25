USE bd_vitoria_lanches;

-- LANCHE (tipo_id = 1)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('X-SALADA', 1, 'carne, queijo, cebola, tomate, alface, pão e picles', 27.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('X-BACON', 1, 'carne, queijo, bacon crocante, alface, tomate e pão com gergelim', 29.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('HOT DOG', 1, 'salsicha, purê de batata, ketchup, mostarda, milho, batata palha e pão', 18.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('MISTO QUENTE', 1, 'pão de forma com presunto e queijo, tostado na chapa', 12.00);

-- SALGADO (tipo_id = 2)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('COXINHA', 2, 'massa de batata recheada com frango desfiado e empanada', 8.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('KIBE', 2, 'trigo, carne moída temperada e hortelã, frito até dourar', 7.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('ESFIHA', 2, 'massa assada recheada com carne temperada', 9.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('EMPADA', 2, 'massa amanteigada recheada com frango cremoso', 8.50);

-- BEBIDA (tipo_id = 3)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('SUCO DE LARANJA', 3, 'suco natural de laranja, sem adição de açúcar', 10.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('ÁGUA MINERAL', 3, 'água mineral sem gás, 500ml', 5.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('REFRIGERANTE COLA', 3, 'refrigerante sabor cola, lata 350ml', 6.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('CHÁ GELADO', 3, 'chá preto gelado com limão, 500ml', 7.00);

-- PORÇÃO (tipo_id = 4)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('BATATA FRITA', 4, 'batatas crocantes servidas com molho especial', 22.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('FRANGO À PASSARINHO', 4, 'pedaços de frango temperados e fritos com alho', 28.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('CALABRESA ACEBOLADA', 4, 'linguiça calabresa fatiada com cebola caramelizada', 25.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('MANDIOCA FRITA', 4, 'mandioca crocante por fora e macia por dentro', 20.00);

-- SORVETE (tipo_id = 5)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('SORVETE DE CHOCOLATE', 5, 'sorvete cremoso sabor chocolate', 10.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('SORVETE DE MORANGO', 5, 'sorvete sabor morango com pedaços da fruta', 10.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('SORVETE DE COCO', 5, 'sorvete sabor coco com lascas naturais', 10.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('SORVETE NAPOLITANO', 5, 'combinação de chocolate, morango e creme', 12.00);

-- SOBREMESA (tipo_id = 6)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PUDIM DE LEITE', 6, 'pudim cremoso com calda de caramelo', 14.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('TORTA DE LIMÃO', 6, 'base crocante com recheio de limão e cobertura de merengue', 15.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('MOUSSE DE MARACUJÁ', 6, 'mousse leve e aerado com calda de maracujá', 13.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('ROCAMBOLE', 6, 'massa de pão de ló recheada com chocolate ou doce de leite', 16.00);

-- DOCE (tipo_id = 7)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('BRIGADEIRO', 7, 'doce de chocolate enrolado e coberto com granulado', 3.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('BEIJINHO', 7, 'doce de coco com leite condensado e açúcar cristal', 3.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PAÇOCA', 7, 'doce de amendoim prensado', 2.50);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('BALA DE COCO', 7, 'bala macia de coco com cobertura açucarada', 2.00);

-- PIZZA (tipo_id = 8)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PIZZA DE CALABRESA', 8, 'molho de tomate, queijo muçarela, calabresa e cebola', 45.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PIZZA DE MUÇARELA', 8, 'molho de tomate e queijo muçarela gratinado', 42.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PIZZA PORTUGUESA', 8, 'presunto, ovos, cebola, pimentão, azeitona e queijo', 48.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PIZZA DE FRANGO COM CATUPIRY', 8, 'frango desfiado com catupiry e muçarela', 50.00);

-- PASTEL (tipo_id = 9)
INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PASTEL DE CARNE', 9, 'massa crocante recheada com carne moída temperada', 9.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PASTEL DE QUEIJO', 9, 'recheio de queijo muçarela derretido', 9.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PASTEL DE PIZZA', 9, 'recheio de queijo, tomate e orégano', 10.00);

INSERT INTO tb_produto 
(
    TB_PRODUTO_NOME,
    TB_PRODUTO_TIPO_PRODUTO_ID,
    TB_PRODUTO_DESC,
    TB_PRODUTO_PREC_UNIT
)
VALUES
('PASTEL DE PALMITO', 9, 'recheio cremoso de palmito com temperos suaves', 10.00);

select * from tb_produto;