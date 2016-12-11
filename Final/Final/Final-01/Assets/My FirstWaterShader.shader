Shader "Custom/MyFirstWaterShader"// name as it appears in unity- the file name does not matter
{
	Properties// public variables" for your shader
	{

		//declares a "Texture" variable for inspector
		_MainTex ("Texture", 2D) = "white" {}
		_WaveHeight ("Wave Height", Float) = 0.5 // no semi -colone 
		_WaveFreq ("Wave Frequency", Float)=2
	}
	SubShader // where our shader code actually starts
	{


		// extra metadate for Unity
		Tags { "RenderType"="Opaque" }
		LOD 100 // Level of Detail
		// more expensive shaders have higher LOD

		Pass // one "update" for your GPU
		{
			CGPROGRAM // HLSL used to be called "CG"- theis is where the program starts
			#pragma vertex vert // the certex shader is called"vert"
			#pragma fragment frag // fragment shader is called"frag"
			// make fog work
			#pragma multi_compile_fog // make fog work
			

			// import all the shader libraries that Unity wrote already
			#include "UnityCG.cginc" // cg inc= CG include


			// struct is like a class, container for data
			// appdata= data we pass from Maya model> vertext shader
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			//vertex to fragment, data from vertex shader to fragment shader
			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			// more variable decleration for use in our shader code
			sampler2D _MainTex;// this has a twin in the Properties
			float4 _MainTex_ST;//ST= scale/transform- float 4 is VEct 4-sth that has 4 dimansion - Automactially used,this variable doesnt have twin
			float _WaveHeight;
			float _WaveFreq;

			//vertext function
			v2f vert (appdata v)
			{	
				v2f o;

				// outside sine wave to adjust Amlitude (height)
				// multiply inside sine func to adjust Frequenct(speed)
				v.vertex +=float4(0, sin(_Time.y*_WaveFreq + v.vertex.x+ v.vertex.z) * _WaveHeight, 0, 0);//  we need to put a variable that is changing all the time so we use Time- to make it lower you multiply by a number like 2
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			

			//fragment program
			// fixed= more optimized" float"
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv + float2(_Time.y, _Time.x)* 0.03);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG// where CG/HLSL code ends here
		}
	}
}
