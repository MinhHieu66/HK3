package com.example.newproject

import android.content.Intent
import android.graphics.Color
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.RadioButton
import android.widget.TextView
import android.widget.Toast
import android.widget.Toast.*
import androidx.appcompat.app.AppCompatActivity

class MainActivityDangNhap : AppCompatActivity() {

    //Khai bao
//    private lateinit var radQuanTriVien : RadioButton
//    private lateinit var radNguoiDung : RadioButton
//    private lateinit var edtEmail : EditText
//    private lateinit var edtMatKhau : EditText
    private lateinit var tvQuenMatKhau : TextView
    private lateinit var btnDangNhap : Button
    private lateinit var tvDangKyNgay : TextView
    private lateinit var btnFacebook : Button
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.layout_dangnhap)

        setControl()
        setEvent()
    }

    private fun setControl(){
//        radQuanTriVien = findViewById(R.id.radQuanTriVien)
//        radNguoiDung = findViewById(R.id.radNguoiDung)
//        edtEmail = findViewById(R.id.edtEmail)
//        edtMatKhau = findViewById(R.id.edtMatKhau)
        tvQuenMatKhau = findViewById(R.id.tvQuenMatKhau)
        btnDangNhap = findViewById(R.id.btnDangNhap)
        tvDangKyNgay = findViewById(R.id.tvDangKyNgay)
        btnFacebook = findViewById(R.id.btnFacebook)
    }
    private fun setEvent(){
        btnDangNhap.setBackgroundColor(Color.parseColor("#000000")) // Màu đen
        btnFacebook.setBackgroundColor(Color.parseColor("#0000DD")) // Màu xanh

        tvQuenMatKhau.setOnClickListener {
            var intent = Intent(this, MainActivityKhoiPhucMatKhau::class.java)
            startActivity(intent)
        }

        tvDangKyNgay.setOnClickListener{
            //Toast.makeText(this, "Hello", Toast.LENGTH_SHORT).show()
            var intent = Intent(this, MainActivityDangKy::class.java)
            startActivity(intent)
        }

    }

}