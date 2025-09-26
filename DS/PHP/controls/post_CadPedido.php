<?php
if ($_POST) {
    if(isset($_POST['btnAddCar'])){
        echo "car";
        require_once 'funcoes.php';
        $idProd = $_POST['id'];
        $quant = $_POST['txtQuant'];
        Inserts::addCarrinho($idProd,$quant);
        header('Location: ../views/MenuPedidos.php');
        exit;
    }
    if(isset($_POST['btnCar'])){
        header('Location: ../views/Carrinho.php');
        exit;
    }
}
?>