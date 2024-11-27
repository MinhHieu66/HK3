package com.example.newproject

import android.content.Intent
import android.graphics.Color
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivityDangKy : AppCompatActivity() {
    //Khai bao
    private lateinit var btnDangKy : Button
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.layout_dangky)
        setControl()
        setEvent()
    }

    private fun setControl(){
        btnDangKy = findViewById(R.id.btnDangKy)
    }

    private fun setEvent(){
        btnDangKy.setBackgroundColor(Color.parseColor("#000000"))
        btnDangKy.setOnClickListener {
            var intent = Intent(this, MainActivityDangNhap::class.java)
            startActivity(intent)
        }
    }
}