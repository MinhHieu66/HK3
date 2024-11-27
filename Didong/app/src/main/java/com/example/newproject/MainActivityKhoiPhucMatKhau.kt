package com.example.newproject

import android.content.Intent
import android.graphics.Color
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivityKhoiPhucMatKhau : AppCompatActivity() {
    //Khai bao
    private lateinit var btnGuiEmail : Button
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.layout_khoiphucmatkhau)
        setControl()
        setEvent()
    }

    private fun setControl(){
        btnGuiEmail = findViewById(R.id.btnGuiEmail)
    }
    private fun setEvent(){
        btnGuiEmail.setBackgroundColor(Color.parseColor("#000000"))
        btnGuiEmail.setOnClickListener {
            val intent = Intent(this, MainActivityDangNhap::class.java)
            startActivity(intent)
        }
    }
}