package com.oyunerbabi.hafta8;

import android.graphics.Color;
import android.os.Bundle;
import android.widget.Button;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.snackbar.Snackbar;

public class MainActivity extends AppCompatActivity {

    Button button;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        button=findViewById(R.id.button);

        button.setOnClickListener(v -> {
            //Toast.makeText(this,"Gönder",Toast.LENGTH_LONG).show();
            //Snackbar.make(v,"Test", Snackbar.LENGTH_LONG).show();
            //Snackbar.make(v,"Test", Snackbar.LENGTH_LONG).setAction("Tamam", view1 ->{}).show();
            /*
            Snackbar.make(v,"Test", Snackbar.LENGTH_LONG).setAction("Tamam", view1 ->{

                button.setBackgroundColor(Color.RED);
            }).show();
            */
            AlertDialog.Builder builder = new  AlertDialog.Builder(this);
            builder.setTitle("Dikkat");
            builder.setMessage("Dosyayı Silmek İstediğinize EMİN Misin?");
            builder.setPositiveButton("Evet",(dialog,which) ->{
                Toast.makeText(this,"Silindi",Toast.LENGTH_SHORT).show();
            });
            builder.setNegativeButton("Hayır",(dialog,which) ->{
                Toast.makeText(this, "Vazgeçildi", Toast.LENGTH_SHORT).show();
            });
            builder.show();

        });

    }
}