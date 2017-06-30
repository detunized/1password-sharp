// Copyright (C) 2017 Dmitry Yakimenko (detunized@gmail.com).
// Licensed under the terms of the MIT license. See LICENCE for details.

using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace OnePassword.Test
{
    [TestFixture]
    public class RsaKeyTest
    {
        [Test]
        public void Parse_returns_key()
        {
            var key = RsaKey.Parse(RsaParameters);
            Assert.That(key.Id, Is.EqualTo("szerdhg2ww2ahjo4ilz57x7cce"));
        }

        //
        // Data
        //

        private static readonly JToken RsaParameters = JToken.FromObject(new
        {
            alg = "RSA-OAEP",
            d = "BF-8y2XKmagkXNv7OP88oypfrtKGgLq6TNS3X2hMZoBZfGXX3YckJrPZelFXMX5OgOyU2yvzT_U-XadpyypX1j4OapsqAEir985PBJ3Y7tgeMXc_dTan00qQAKB7c2gaLjokvJGaDOx-h86RHsoLcUaC7wMnsc0SMcUiihXfMNAA0PkdkmomT79H8m0HYBGYQCGKj323K7XScdTyEBGe5IGea5Y-Gy2qeX42Js4uxFwz0CymkTz9hTJOOxCNwGbgRbk2I2yOiLQysY5whp_B6MBAEzocJAM8V4PFmPCuw8jlyL79v5i6oIMW7lKo5hbyRhINECJ2xAWEeY78hl2asQ",
            dp = "SODQhw9KS6eOBC02dYkxNPf2E9yQ4el__NOsbg6bgSul9Er9_z9bp60WgBf8u9b7wMclZ-9iO17-hinxNQy4_MQrs6KCssaejJ510qV3zBkW6kXcdbvLyB1C0xQe4LPmdgDAtt8Ft31_rLN_VPP_GgreWpU6rrUKXzx47hpE60E",
            dq = "Sh1S6l90OUXWD1Oz7lb_VtUXygqxknVFFDfmSOdjw5X4IYjromB-FxdacffTBo-I7v-MfrJqqWsDtgpJvVAePExHQ0J-ud0gHtl-ClKOMnDVZeu5apU4WWNN-dhcyE43eHXt1SsNM-wUwoxsjTFy5ibCbuiH6dSUyk81TtxDnKU",
            e = "AQAB",
            ext = true,
            kty = "RSA",
            n = "v1wkFPMC-1eAV46KP_46g8L2-eImJyybx8dMPXdAZJ04hd3dtq_3bbbjUXxT4X7NoCSIrGZHE5O1TTTiBX3zHLEoyT33s-ViLNJXUHfkF2vXQYcqHnBIyr9H-p08eki7A9Cn8K1kk2d4BPj7GtvPWYp11fmgdmPNN5jVJKRG3ggrnluA4DB_txNnTPOoql-l5JCacFwiGIdYH3oaHZ9jjGTVwaFIDTv39ttnrA5EXyEJOPxQK9S-3qk69LJShfSrmWuTU_QUZjCOiVOoRtzcHzCRcQjWzGvTLFe64qze03exMBUU8O4ACfGUjlu-UIiK0V6F6gamofZmmL5pHr7Gjw",
            p = "91GR0HzxTGEOXa7ofmeXn9R0YqjkMfrvVAnhDpGf6uKc80lqZVjM-mOpNx_8BVoHhrgub9aQXi_aULVwnBNGVGBnZO8dw3bKmD7QFLkWFCkvxCVrDNXQHjzN8yd5zp5Rk4CeiW9OI0Al42i5D1CmeC22Q0gutpxvaDrb3yriKu0",
            q = "xhO4gaSTf5KWAiXoral-fAbq4dBOz2boptXJmN_KVGlv4vJ2K0NXH-XKsDPVI5WCwE104mcdoDlDOJ_ZU9lzx5GgvoUwNr5luScdtY0LY7rYq-OuTYf5o2BPJOsAh2mAFISbX6gqP7HrO1SH0LVmSHfaTz8lti0gX0A9yETX--s",
            qi = "FW4wJf5lP5k7OfH4-w34BvHzPnnhj96_GfKUcyzeNRL1XVJ64a7C3OIno30DQTrUHtbVeZ2zsnPLwtvuMkQEVXcvt6pLCxGnWx9eO71v4yzlJ4_6wDx5xvKwNFrspOBDAC_XeG1GyJu-cVd5azNARKaf0JPFO7MQ3NJ7-ymFQTo",
            kid = "szerdhg2ww2ahjo4ilz57x7cce"
        });

    }
}
