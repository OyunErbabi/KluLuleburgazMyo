package com.oyunerbabi.hafta2_1;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    Button yazButton;
    TextView textGoster;
    Button silButton;

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

        yazButton = findViewById(R.id.YazButton);
        textGoster = findViewById(R.id.textGoster);
        silButton = findViewById(R.id.SilButton);

        yazButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textGoster.setText("İlk Andoroid Projemi Yazdım...");
            }
        });

        silButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                textGoster.setText("");
            }
        });


    }
}