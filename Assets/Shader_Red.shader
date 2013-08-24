Shader "Custom/NewShader" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_ColorTint ("Tint", Color) = (1.0, 0.6, 0.6, 1.0)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		CGPROGRAM
		#pragma surface surf Lambert finalcolor:myColor

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		fixed4 _ColorTint;
		void myColor (Input IN, SurfaceOutput OUT, inout fixed4 color) {
			color *= _ColorTint;
		}

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			//o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
