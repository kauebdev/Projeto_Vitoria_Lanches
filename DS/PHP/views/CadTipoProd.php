<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>VITORIA LANCHES</title>
</head>
<body>
    <center>
        <h1>Cadastro de Tipo Produto</h1>

        <form action="../controls/post_CadProd.php" method="post">
            digite a descrição: <input type="text" name="txtDesc" required><br><br>

            <input type="submit" value="Cadastrar" name="btnCadTipoProd"> <br><br>
        </form>
        <form action="../controls/post_CadProd.php" method="post">
            <input type="submit" value="voltar" name="btnVoltar">
        </form>
    </center>
</body>

</html>