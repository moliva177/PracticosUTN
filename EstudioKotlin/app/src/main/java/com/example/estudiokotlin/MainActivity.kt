package com.example.estudiokotlin

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val hellotext = findViewById<TextView>(R.id.tvSaludo)

        hellotext.text = "Hola maxito"
    }
}