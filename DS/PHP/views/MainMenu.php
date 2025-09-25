<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Vitoria Lanches</title>
</head>

<body>
    <center>
        <div class="Menu">
        <?php
        require_once '../models/dados.php';
        session_start();
        $tipo = SessaoUsers::getTipo();
        if ($tipo == 'ADMIN') {
            include '../views/MainMenuAdmin.php';
        } else {
            include '../views/MainMenuClie.php';
        }
        ?>
        </div>
    </center>
</body>

</html>