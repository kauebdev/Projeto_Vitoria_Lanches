<?php
if ($_POST){
    if(isset($_POST['btnProd'])){
        header("location: ../views/CadProd.php");
        exit;
    }
    if(isset($_POST['btnClie'])){
        header("location: ../views/CadUsers.php");
        exit;
    }
    if(isset($_POST['btnPed'])){
        header("location: ../views/MenuPedidos.php");
        exit;
    }
}
?>