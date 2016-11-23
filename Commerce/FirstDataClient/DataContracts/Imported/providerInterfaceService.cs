//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", ConfigurationName="providerInterface")]
public interface providerInterface
{
    
    // CODEGEN: Generating message contract since the operation pubReversal is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute()]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    pubReversalResponse1 pubReversal(pubReversalRequest1 request);
    
    // CODEGEN: Generating message contract since the operation pubRedemption is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute()]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    pubRedemptionResponse1 pubRedemption(pubRedemptionRequest1 request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubReversalRequest
{
    
    private string mIDField;
    
    private string tokenField;
    
    private string reqIDField;
    
    private string revReasonField;
    
    private int revAmtField;
    
    private bool revAmtFieldSpecified;
    
    private string offerIDField;
    
    private string rdmptTranIDField;
    
    private int authAmtField;
    
    private bool authAmtFieldSpecified;
    
    private string dateTimeField;
    
    private string currCodeField;
    
    private int redemptionTypeField;
    
    private string offerAcceptIDField;
    
    private string offerMIDField;
    
    private string bECodeField;
    
    private string tenderTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MID
    {
        get
        {
            return this.mIDField;
        }
        set
        {
            this.mIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string token
    {
        get
        {
            return this.tokenField;
        }
        set
        {
            this.tokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string revReason
    {
        get
        {
            return this.revReasonField;
        }
        set
        {
            this.revReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int revAmt
    {
        get
        {
            return this.revAmtField;
        }
        set
        {
            this.revAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool revAmtSpecified
    {
        get
        {
            return this.revAmtFieldSpecified;
        }
        set
        {
            this.revAmtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerID
    {
        get
        {
            return this.offerIDField;
        }
        set
        {
            this.offerIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string rdmptTranID
    {
        get
        {
            return this.rdmptTranIDField;
        }
        set
        {
            this.rdmptTranIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int authAmt
    {
        get
        {
            return this.authAmtField;
        }
        set
        {
            this.authAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool authAmtSpecified
    {
        get
        {
            return this.authAmtFieldSpecified;
        }
        set
        {
            this.authAmtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string dateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string currCode
    {
        get
        {
            return this.currCodeField;
        }
        set
        {
            this.currCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int redemptionType
    {
        get
        {
            return this.redemptionTypeField;
        }
        set
        {
            this.redemptionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerAcceptID
    {
        get
        {
            return this.offerAcceptIDField;
        }
        set
        {
            this.offerAcceptIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerMID
    {
        get
        {
            return this.offerMIDField;
        }
        set
        {
            this.offerMIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BECode
    {
        get
        {
            return this.bECodeField;
        }
        set
        {
            this.bECodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string tenderType
    {
        get
        {
            return this.tenderTypeField;
        }
        set
        {
            this.tenderTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubReversalResponse
{
    
    private string reqIDField;
    
    private string respCodeField;
    
    private int revAmtField;
    
    private bool revAmtFieldSpecified;
    
    private string rdmptTranIDField;
    
    private string errorMsgField;
    
    private string reasonCodeField;
    
    private string provIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string respCode
    {
        get
        {
            return this.respCodeField;
        }
        set
        {
            this.respCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int revAmt
    {
        get
        {
            return this.revAmtField;
        }
        set
        {
            this.revAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool revAmtSpecified
    {
        get
        {
            return this.revAmtFieldSpecified;
        }
        set
        {
            this.revAmtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string rdmptTranID
    {
        get
        {
            return this.rdmptTranIDField;
        }
        set
        {
            this.rdmptTranIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string errorMsg
    {
        get
        {
            return this.errorMsgField;
        }
        set
        {
            this.errorMsgField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reasonCode
    {
        get
        {
            return this.reasonCodeField;
        }
        set
        {
            this.reasonCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string provID
    {
        get
        {
            return this.provIDField;
        }
        set
        {
            this.provIDField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubReversalRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubReversalRequest pubReversalRequest;
    
    public pubReversalRequest1()
    {
    }
    
    public pubReversalRequest1(pubReversalRequest pubReversalRequest)
    {
        this.pubReversalRequest = pubReversalRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubReversalResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubReversalResponse pubReversalResponse;
    
    public pubReversalResponse1()
    {
    }
    
    public pubReversalResponse1(pubReversalResponse pubReversalResponse)
    {
        this.pubReversalResponse = pubReversalResponse;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubRedemptionRequest
{
    
    private string mIDField;
    
    private string tokenField;
    
    private int authAmtField;
    
    private string dateTimeField;
    
    private string currCodeField;
    
    private string reqIDField;
    
    private string offerIDField;
    
    private int redemptionTypeField;
    
    private string offerAcceptIDField;
    
    private string offerMIDField;
    
    private string bECodeField;
    
    private string tenderTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MID
    {
        get
        {
            return this.mIDField;
        }
        set
        {
            this.mIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string token
    {
        get
        {
            return this.tokenField;
        }
        set
        {
            this.tokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int authAmt
    {
        get
        {
            return this.authAmtField;
        }
        set
        {
            this.authAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string dateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string currCode
    {
        get
        {
            return this.currCodeField;
        }
        set
        {
            this.currCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerID
    {
        get
        {
            return this.offerIDField;
        }
        set
        {
            this.offerIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int redemptionType
    {
        get
        {
            return this.redemptionTypeField;
        }
        set
        {
            this.redemptionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerAcceptID
    {
        get
        {
            return this.offerAcceptIDField;
        }
        set
        {
            this.offerAcceptIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerMID
    {
        get
        {
            return this.offerMIDField;
        }
        set
        {
            this.offerMIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BECode
    {
        get
        {
            return this.bECodeField;
        }
        set
        {
            this.bECodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string tenderType
    {
        get
        {
            return this.tenderTypeField;
        }
        set
        {
            this.tenderTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.offers.firstdata.com/v1/provider/")]
public partial class pubRedemptionResponse
{
    
    private int redemptionAmtField;
    
    private bool redemptionAmtFieldSpecified;
    
    private string reqIDField;
    
    private string respCodeField;
    
    private string errorMsgField;
    
    private string provIDField;
    
    private string pubIDField;
    
    private string pubNameField;
    
    private string offerIDField;
    
    private string offerDescField;
    
    private string rdmptTranIDField;
    
    private string receiptTxtField;
    
    private string reasonCodeField;
    
    private string offerAcceptIDField;
    
    private string consumerIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int redemptionAmt
    {
        get
        {
            return this.redemptionAmtField;
        }
        set
        {
            this.redemptionAmtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool redemptionAmtSpecified
    {
        get
        {
            return this.redemptionAmtFieldSpecified;
        }
        set
        {
            this.redemptionAmtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reqID
    {
        get
        {
            return this.reqIDField;
        }
        set
        {
            this.reqIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string respCode
    {
        get
        {
            return this.respCodeField;
        }
        set
        {
            this.respCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string errorMsg
    {
        get
        {
            return this.errorMsgField;
        }
        set
        {
            this.errorMsgField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string provID
    {
        get
        {
            return this.provIDField;
        }
        set
        {
            this.provIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string pubID
    {
        get
        {
            return this.pubIDField;
        }
        set
        {
            this.pubIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string pubName
    {
        get
        {
            return this.pubNameField;
        }
        set
        {
            this.pubNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerID
    {
        get
        {
            return this.offerIDField;
        }
        set
        {
            this.offerIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerDesc
    {
        get
        {
            return this.offerDescField;
        }
        set
        {
            this.offerDescField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string rdmptTranID
    {
        get
        {
            return this.rdmptTranIDField;
        }
        set
        {
            this.rdmptTranIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiptTxt
    {
        get
        {
            return this.receiptTxtField;
        }
        set
        {
            this.receiptTxtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reasonCode
    {
        get
        {
            return this.reasonCodeField;
        }
        set
        {
            this.reasonCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string offerAcceptID
    {
        get
        {
            return this.offerAcceptIDField;
        }
        set
        {
            this.offerAcceptIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string consumerID
    {
        get
        {
            return this.consumerIDField;
        }
        set
        {
            this.consumerIDField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubRedemptionRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubRedemptionRequest pubRedemptionRequest;
    
    public pubRedemptionRequest1()
    {
    }
    
    public pubRedemptionRequest1(pubRedemptionRequest pubRedemptionRequest)
    {
        this.pubRedemptionRequest = pubRedemptionRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class pubRedemptionResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.offers.firstdata.com/v1/provider/", Order=0)]
    public pubRedemptionResponse pubRedemptionResponse;
    
    public pubRedemptionResponse1()
    {
    }
    
    public pubRedemptionResponse1(pubRedemptionResponse pubRedemptionResponse)
    {
        this.pubRedemptionResponse = pubRedemptionResponse;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface providerInterfaceChannel : providerInterface, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class providerInterfaceClient : System.ServiceModel.ClientBase<providerInterface>, providerInterface
{
    
    public providerInterfaceClient()
    {
    }
    
    public providerInterfaceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public providerInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public providerInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public providerInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    pubReversalResponse1 providerInterface.pubReversal(pubReversalRequest1 request)
    {
        return base.Channel.pubReversal(request);
    }
    
    public pubReversalResponse pubReversal(pubReversalRequest pubReversalRequest)
    {
        pubReversalRequest1 inValue = new pubReversalRequest1();
        inValue.pubReversalRequest = pubReversalRequest;
        pubReversalResponse1 retVal = ((providerInterface)(this)).pubReversal(inValue);
        return retVal.pubReversalResponse;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    pubRedemptionResponse1 providerInterface.pubRedemption(pubRedemptionRequest1 request)
    {
        return base.Channel.pubRedemption(request);
    }
    
    public pubRedemptionResponse pubRedemption(pubRedemptionRequest pubRedemptionRequest)
    {
        pubRedemptionRequest1 inValue = new pubRedemptionRequest1();
        inValue.pubRedemptionRequest = pubRedemptionRequest;
        pubRedemptionResponse1 retVal = ((providerInterface)(this)).pubRedemption(inValue);
        return retVal.pubRedemptionResponse;
    }
}